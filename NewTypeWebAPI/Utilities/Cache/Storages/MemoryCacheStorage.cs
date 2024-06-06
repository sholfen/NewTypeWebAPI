using System.Collections.Concurrent;

namespace NewTypeWebAPI.Utilities.Cache.Storages
{
    public class MemoryCacheStorage
    {
        private ConcurrentDictionary<string, object> _cache = new ConcurrentDictionary<string, object>();

        public MemoryCacheStorage()
        {

        }

        public T? Get<T>(string key)
        {
            T? item = default;
            if (_cache.ContainsKey(key))
            {
                if (_cache[key] != null)
                {
                    item = (T)_cache[key];
                }
            }
            else
            {
                throw new ArgumentException("key is not exist.");
            }

            return item;
        }

        public string GetString(string key)
        {
            throw new NotSupportedException();
        }

        public void Set<T>(string key, T value)
        {
            if (value == null)
            {
                return;
            }
            _cache.TryAdd(key, value);
        }

        public void SetString(string key, string value)
        {
            _cache.TryAdd(key, value);
        }
    }
}
