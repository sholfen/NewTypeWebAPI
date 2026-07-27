using DataRepository.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Repositories.Implements
{
    public class SessionStorageRepository : BaseRepository, ISessionStorageRepository
    {
        private IConfiguration config;

        public SessionStorageRepository(IConfiguration configRoot) : base()
        {
            config = configRoot;
        }
    }
}
