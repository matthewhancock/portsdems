using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace portsmouth_democrats {
    public class Application : Common.Application {
        public override void LoadFromConfig(IConfiguration Configuration) {
            //var c = new Configuration();
            var db_servername = Configuration["db:servername"];
            var db_database = Configuration["db:database"];
            var db_username = Configuration["db:username"];
            var db_password = Configuration["db:password"];
            _dbconnectionstring = $"Server=tcp:{Configuration["db:servername"]}.database.windows.net,1433;Database={Configuration["db:database"]};User ID={Configuration["db:username"]}@{Configuration["db:servername"]};Password={Configuration["db:password"]};Trusted_Connection=False;Encrypt=True;Connection Timeout=30;";
            
            //return c;
        }

        private static string _dbconnectionstring;
        public static class Configuration {
            public static string DBConnectionString { get { return _dbconnectionstring; } }
        }

        public override EnvironmentConfiguration LoadFromEnvironment(IHostingEnvironment env) {
            var e = new EnvironmentConfiguration();
            return e;
        }
    }
}
