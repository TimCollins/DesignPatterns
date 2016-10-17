namespace BlackWasp.Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private Singleton() { }

        public static Singleton GetSingleton()
        {
            lock (_lock)
            {
                // Could also do return _instance ?? (_instance = new Singleton());
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}
