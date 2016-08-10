using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace portsmouth_democrats {
    public class Application : Common.Application {
        public override Configuration LoadFromConfig(IConfiguration Configuration) {
            var c = new Configuration();
            return c;
        }

        public override EnvironmentConfiguration LoadFromEnvironment(IHostingEnvironment env) {
            var e = new EnvironmentConfiguration();
            return e;
        }
    }
}
