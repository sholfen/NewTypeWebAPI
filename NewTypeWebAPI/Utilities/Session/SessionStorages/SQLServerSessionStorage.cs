namespace NewTypeWebAPI.Utilities.Session.SessionStorages
{
    public class SQLServerSessionStorage : ISessionStorage
    {
        public SQLServerSessionStorage()
        {
            _connectionString = string.Empty;
        }

        private string _connectionString;

        public void SetConnectionString(string connectionString)
        {
            _connectionString = connectionString;
        }

        private void InitDB()
        {

        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Set<T>(string key, T value)
        {
            throw new NotImplementedException();
        }
    }
}
