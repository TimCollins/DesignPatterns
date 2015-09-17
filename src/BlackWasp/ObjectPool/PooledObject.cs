using System;

namespace BlackWasp.ObjectPool
{
    public class PooledObject
    {
        private DateTime _createdAt = DateTime.Now;

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public string TempData { get; set; }
    }
}
