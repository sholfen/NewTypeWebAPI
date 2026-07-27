namespace NewTypeWebAPI.Utilities.Session.SessionStorages
{
    public class MemorySessionStorage : ISessionStorage
    {
        private Dictionary<string, object> _sessions;

        public MemorySessionStorage() 
        {
            _sessions = new Dictionary<string, object>();
        }   

        public T Get<T>(string key)
        {
            if (_sessions.ContainsKey(key))
            {
                return (T)_sessions[key];
            }
            throw new NullReferenceException("no object in session.");
        }

        public void Set<T>(string key, T value)
        {
            if (value != null)
            {
                if (_sessions.ContainsKey(key))
                {
                    _sessions[key] = value;
                }
                else
                {
                    _sessions.Add(key, value);
                }
            }
            else 
            {
                throw new NullReferenceException("object is null.");
            }
        }
    }
}
