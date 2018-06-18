using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace API.Utils
{
    public static class ModuleHelper
    {
        public static string ModuleName { get; set; }
        public static IHostingEnvironment env { get; set; }
        public static IConfigurationRoot Configuration { get; set; }
        public static IServiceCollection services { get; set; }
        public static IApplicationBuilder app { get; set; }
        public static ILoggerFactory loggerFactory { get; set; }
    }
}
