using Microsoft.Framework.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portsmouth_democrats {
    public class Application {
        private static string _dbconnectionstring;
        public static void LoadFromConfig(IConfiguration Configuration) {
            _dbconnectionstring = $"Server=tcp:{Configuration.Get("db:servername")}.database.windows.net,1433;Database={Configuration.Get("db:database")};User ID={Configuration.Get("db:username")}@{Configuration.Get("db:servername")};Password={Configuration.Get("db:password")};Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
        }
        public static string DBConnectionString { get { return _dbconnectionstring; } }
    }
}
