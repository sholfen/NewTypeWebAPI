using NewTypeWebAPI.Utilities.Models;
using NewTypeWebAPI.Utilities.Session.SessionStorages;

namespace NewTypeWebAPI.Utilities.Session
{
    public enum SessionTypeEnum
    {
        Memory = 0,
        DB = 1,
        NoSQL = 2,
        Azure = 3,
    }

    public class SessionTool
    {
        private static ISessionStorage? _storage;

        public static void InitSessionPool(SessionTypeEnum sessionType)
        {
            switch (sessionType)
            {
                case SessionTypeEnum.Memory:
                    _storage = new MemorySessionStorage();
                    break;
                case SessionTypeEnum.Azure:
                    _storage = new AzureSessionStorage();
                    break;
                default:
                    _storage = new MemorySessionStorage();
                    break;
            }
        }

        public SessionInfo GetSession(string token)
        {
            SessionInfo sessionInfo = new SessionInfo();    
            return sessionInfo;
        }
    }
}
