using NewTypeWebAPI.Utilities.Logging;
using System.Collections.Concurrent;

namespace NewTypeWebAPI.Utilities
{
    public static class SwissKnife
    {
        static SwissKnife()
        {
            Logger = new FileLogger(); 
            //Logger = FileLogger.Default;
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

        public static void RequestDelay(string token, string requestId)
        {

        }

        public static string ToStringYYYYMMDD(this DateTime dt)
        {
            return dt.ToString(@"yyyy/MM/DD");
        }
    }

    public class RequestDelayHelper
    {
        private ConcurrentDictionary<string, string> _dic = new ConcurrentDictionary<string, string>();

        public RequestDelayHelper()
        {

        }
    }
}
