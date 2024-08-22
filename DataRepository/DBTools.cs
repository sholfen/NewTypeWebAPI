using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataRepository
{
    public static class DBTools
    {
        static DBTools()
        {

        }

        public static string ConnectionString { get; set; } = string.Empty;

        private static ConcurrentDictionary<string, ConcurrentDictionary<string, string>>? SQLCache;
        public static void LoadSQLtoCache()
        {
            Stream stream = File.Open(@"sql.json", FileMode.Open);
            StreamReader reader = new StreamReader(stream);
            string line = reader.ReadToEnd();
            SQLCache = JsonSerializer.Deserialize<ConcurrentDictionary<string, ConcurrentDictionary<string, string>>>(line);
            if (SQLCache == null) 
            {
                throw new NullReferenceException("SQL file is null.");
            }

            reader.Close();
            stream.Close();
        }

        public static string GetSQL(string id,string key)
        {
            ConcurrentDictionary<string, string>? dict = null;
            SQLCache?.TryGetValue(id, out dict);
            if(dict == null)
            {
                throw new NullReferenceException("SQLCache is null");
            }
            string? sql = dict[key];
            if (string.IsNullOrEmpty(sql))
            {
                return string.Empty;
            }
            return sql;
        }

        public static void SetDBConnectionString(this IConfigurationManager configurationManager, string key)
        {
            if (string.IsNullOrEmpty(configurationManager.GetConnectionString(key)))
            {
                throw new InvalidOperationException("no connection string");
            }
            ConnectionString = configurationManager.GetConnectionString(key) ?? string.Empty;
            //y = x ?? "Hello";
        }
    }
}
