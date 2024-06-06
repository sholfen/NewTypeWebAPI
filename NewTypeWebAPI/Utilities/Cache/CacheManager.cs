using NewTypeWebAPI.Utilities.Cache.Storages;

namespace NewTypeWebAPI.Utilities.Cache
{
    public class CacheManager
    {
        private ICacheStorage _storage;

        public CacheManager(ICacheStorage storage) 
        {
            _storage = storage;
        }
    }
}
