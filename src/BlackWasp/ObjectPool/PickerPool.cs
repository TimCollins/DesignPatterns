using System;
using System.Collections.Generic;

namespace BlackWasp.ObjectPool
{
    public static class PickerPool
    {
        private const int PickerCount = 5;

        private static readonly List<AutomatedPicker> _available = new List<AutomatedPicker>();
        private static readonly List<AutomatedPicker> _inUse = new List<AutomatedPicker>();

        static PickerPool()
        {
            for (int i = 1; i <= PickerCount; i++)
            {
                _available.Add(new AutomatedPicker(i));
            }
        }

        public static AutomatedPicker GetPicker()
        {
            lock (_available)
            {
                if (_available.Count == 0)
                {
                    throw new InvalidOperationException("No pickers are available");
                }

                AutomatedPicker picker = _available[0];
                _inUse.Add(picker);
                _available.RemoveAt(0);

                return picker;
            }
        }

        public static void ReleasePicker(AutomatedPicker picker)
        {
            Reset(picker);

            lock (_available)
            {
                _available.Add(picker);
                _inUse.Remove(picker);
            }
        }

        private static void Reset(AutomatedPicker picker)
        {
            if (picker.Carrying != null)
            {
                picker.Drop();
            }

            picker.GoToLocation("Recharging Station");
        }
    }
}
