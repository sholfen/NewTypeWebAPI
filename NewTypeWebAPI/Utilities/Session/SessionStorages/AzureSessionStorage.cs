namespace NewTypeWebAPI.Utilities.Session.SessionStorages
{
    public class AzureSessionStorage : ISessionStorage
    {
        public AzureSessionStorage()
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
