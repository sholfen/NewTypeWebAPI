using Microsoft.AspNetCore.SignalR;

namespace NewTypeWebAPI.Utilities.Session
{
    public interface ISessionStorage
    {
        T Get<T>(string key);
        void Set<T>(string key, T value);
    }
}
