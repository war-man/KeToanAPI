using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Utils
{
    public static class ConfigHelper
    {
        public static DbContextOptionsBuilder CreateOption(this DbContextOptionsBuilder optionsBuilder, IConfigurationRoot Configuration)
        {
            var connectProvider = Configuration.GetConnectionString("UserProvider");
            var connectString = Configuration.GetConnectionString(connectProvider);
            optionsBuilder.UseSqlServer(connectString);
            switch (connectProvider)
            {
                case "UseSqlServer":
                    optionsBuilder.UseSqlServer(connectString);
                    break;
                case "UseMySql":
                    optionsBuilder.UseMySql(connectString);
                    break;
                default:
                    optionsBuilder.UseInMemoryDatabase();
                    break;
            }
            return optionsBuilder;
        }
        public static DbContextOptionsBuilder CreateOption(this DbContextOptionsBuilder optionsBuilder)
        {
            return optionsBuilder.CreateOption(ModuleHelper.Configuration);
        }
    }
}
