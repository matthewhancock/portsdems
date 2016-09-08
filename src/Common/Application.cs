using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Common {
    public abstract class Application {
        private static string _path;

        private static EnvironmentConfiguration _env;
        //private static Configuration _config;

        internal void RootLoadFromEnvironment(IHostingEnvironment env) {
            _path = env.ContentRootPath;
            LoadFromEnvironment(env);
        }
        public abstract EnvironmentConfiguration LoadFromEnvironment(IHostingEnvironment env);
        internal void RootLoadFromConfig(IConfiguration Configuration) {
            /*_config =*/ LoadFromConfig(Configuration);
        }
        public abstract void LoadFromConfig(IConfiguration Configuration);

        public class EnvironmentConfiguration {
            public string ApplicationBasePath { get; internal set; }
        }
        public static class Environment {
            public static string ApplicationBasePath { get { return _path; } }
            public static EnvironmentConfiguration Configuration { get { return _env; } }
        }
    }
}
