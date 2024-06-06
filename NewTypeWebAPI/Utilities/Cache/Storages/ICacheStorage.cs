namespace NewTypeWebAPI.Utilities.Cache.Storages
{
    public interface ICacheStorage
    {
        string GetString(string key);
        T GetItem<T>(string key);
        object GetItem(string key);
    }
}
