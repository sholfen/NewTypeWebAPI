using NewTypeWebAPI.Utilities.Logging;

namespace NewTypeWebAPI.Utilities
{
    public static class SwissKnife
    {
        static SwissKnife()
        {
            Logger = new FileLogger(); 
        }

        private static ILogger Logger;

        public static string GetVersionNumber()
        {
            string version = string.Empty;
            return version;
        }

        public static void PrintLog(string message)
        {
            Console.WriteLine(message);
        }

        public static void ServerInit()
        {
            ServerStart.LoadAllClasses();
            ServerStart.SetupLoggerSetting();
        }
    }
}
