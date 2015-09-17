using System;

namespace BlackWasp.ObjectPool
{
    /// <summary>
    /// Object to create and allocate through a pool.
    /// </summary>
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
