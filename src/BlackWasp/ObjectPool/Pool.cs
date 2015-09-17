using System.Collections.Generic;

namespace BlackWasp.ObjectPool
{
    /// <summary>
    /// The object pool itself. Controls access to the pooled objects, maintains a list of available
    /// objects and a list of objects that are in use.
    /// </summary>
    public static class Pool
    {
        private static readonly List<PooledObject> _available = new List<PooledObject>();
        private static readonly List<PooledObject> _inUse = new List<PooledObject>();

        /// <summary>
        /// Get an object from the pool.
        /// If there are no objects available then a new one is created.
        /// If there are objects available then the first available object is allocated and moved
        /// from the Available list to the In Use list.
        /// </summary>
        /// <returns></returns>
        public static PooledObject GetObject()
        {
            lock (_available)
            {
                if (_available.Count != 0)
                {
                    PooledObject po = _available[0];
                    _inUse.Add(po);
                    _available.RemoveAt(0);

                    return po;
                }
                else
                {
                    PooledObject po = new PooledObject();
                    _inUse.Add(po);
                    return po;
                }
            }
        }

        /// <summary>
        /// This method does the reverse of GetObject(). The specified object is cleaned up and then
        /// removed from the In Use list and added to the available list.
        /// </summary>
        /// <param name="po">The object to release back to the pool.</param>
        public static void ReleaseObject(PooledObject po)
        {
            CleanUp(po);

            lock (_available)
            {
                _available.Add(po);
                _inUse.Remove(po);
            }
        }

        /// <summary>
        /// Clean up the object by nulling a property.
        /// </summary>
        /// <param name="po"></param>
        private static void CleanUp(PooledObject po)
        {
            po.TempData = null;
        }
    }
}
