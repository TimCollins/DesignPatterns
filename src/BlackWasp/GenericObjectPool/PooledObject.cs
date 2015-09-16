namespace BlackWasp.GenericObjectPool
{
    public class PooledObject
    {
        private static readonly object _idLock = new object();
        private static int _nextId = 1;

        public int PermanentId { get; private set; }
        public string Name { get; set; }

        public PooledObject()
        {
            lock (_idLock)
            {
                PermanentId = _nextId++;
            }
        }
    }
}
