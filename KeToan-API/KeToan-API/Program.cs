using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("hosting.json", optional: true)
                .AddCommandLine(args)
                .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                .Build();
            string moduleName = config.GetSection("Module").Get<string>();
            Utils.ModuleHelper.ModuleName = string.IsNullOrEmpty(moduleName) ? System.Reflection.Assembly.GetEntryAssembly().GetName().Name : moduleName;

            var urls = config.GetSection("Hosting").Get<string[]>();
            if (urls == null || urls.Length == 0)
                urls = new string[] { config.GetValue<string>("Urls") };

            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls(urls)
                .Build();

            host.Run();
        }
    }
}
