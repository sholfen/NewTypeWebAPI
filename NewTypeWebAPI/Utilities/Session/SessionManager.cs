
namespace NewTypeWebAPI.Utilities.Session
{
    public class SessionManager
    {
        //public SessionManager Instance 
        //{   get
        //    {
        //        if (_instance == null)
        //        {
        //            _instance = new SessionManager();
        //        }
        //        return _instance;
        //    }
        //}
        //private SessionManager? _instance;
        private static readonly Lazy<SessionManager> _instance = new(() => new SessionManager());
        public static SessionManager Instance => _instance.Value;

        private SessionManager()
        {

        }
    }
}
