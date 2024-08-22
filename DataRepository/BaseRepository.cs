using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class BaseRepository
    {

        private BaseDbContext _db;

        protected BaseDbContext Context
        { get { return _db; } }

        public BaseRepository()
        {
            _db = new BaseDbContext();
        }

        public void AddItem<T>(T item) where T : class
        {
            _db.Add(item);
            _db.SaveChanges();
        }

        public void UpdateItem<T>(T item) where T : class
        {
            _db.Update(item);
            _db.SaveChanges();
        }

        public void ExecuteSQL(string sql, object[] parameters)
        {
            _db.Database.ExecuteSqlRaw(sql, parameters);
        }
    }
}
