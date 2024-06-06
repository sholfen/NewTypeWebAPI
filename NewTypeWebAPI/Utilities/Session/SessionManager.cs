
namespace NewTypeWebAPI.Utilities.Session
{
    public class SessionManager
    {
        public SessionManager Instance 
        {   get
            {
                if (_instance == null)
                {
                    _instance = new SessionManager();
                }
                return _instance;
            }
        }
        private SessionManager? _instance;
        
        private SessionManager()
        {

        }
    }

    public class NewSession : ISession
    {
        bool ISession.IsAvailable => throw new NotImplementedException();

        string ISession.Id => throw new NotImplementedException();

        IEnumerable<string> ISession.Keys => throw new NotImplementedException();

        void ISession.Clear()
        {
            throw new NotImplementedException();
        }

        Task ISession.CommitAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        Task ISession.LoadAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        void ISession.Remove(string key)
        {
            throw new NotImplementedException();
        }

        void ISession.Set(string key, byte[] value)
        {
            throw new NotImplementedException();
        }

        bool ISession.TryGetValue(string key, out byte[]? value)
        {
            throw new NotImplementedException();
        }
    }
}
