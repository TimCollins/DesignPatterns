namespace BlackWasp.Singleton
{
    public sealed class ApplicationState
    {
        // Singleton implementation
        private static ApplicationState _instance;
        private static object _lock = new object();

        private ApplicationState() { }

        public static ApplicationState GetApplicationState()
        {
            lock (_lock)
            {
                return _instance ?? (_instance = new ApplicationState());
            }
        }

        // Application state information
        public string UserName { get; set; }
        public int UserId { get; set; }
        public bool IsConnected { get; set; }
    }
}
