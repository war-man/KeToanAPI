using API.Services;
using API.TokenProvider;
using API.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            Utils.ModuleHelper.env = env;

            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Utils.ModuleHelper.services = services;
            services.AddCors();

            services.AddMvc(o =>
            {
                o.OutputFormatters.RemoveType<XmlSerializerOutputFormatter>();

                //var policy = new AuthorizationPolicyBuilder()
                //     .RequireAuthenticatedUser()
                //     .Build();
                //o.Filters.Add(new AuthorizeFilter(policy));
            })
            .AddJsonOptions(o =>
            {
                o.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver();
                o.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
                o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                o.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });

            services.AddDbContext<zModel>(o => o.CreateOption(Configuration));
            services.AddSingleton<IRepositoryCollection, RepositoryCollection>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            Utils.ModuleHelper.app = app;
            Utils.ModuleHelper.Configuration = Configuration;
            Utils.ModuleHelper.loggerFactory = loggerFactory;
            if (env.IsDevelopment())
            {
                app.UseCors(o => o
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowAnyOrigin()
                        .Build()
                );
                loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                loggerFactory.AddDebug();
            }
            else
            {
                app.UseCors(o =>
                {
                    var corsConfig = Configuration.GetSection("CorsConfig");
                    o.WithOrigins(corsConfig.GetSection("Origins").Get<string[]>());
                    o.AllowAnyHeader();
                    o.AllowAnyMethod();

                });

                loggerFactory.AddConsole(LogLevel.Information);
                loggerFactory.AddDebug();
            }


            app.SeedData();

            app.UseJwtBearerAuthentication(TokenHelper.BearerOption());
            app.UseMiddleware<TokenProviderMiddleware>(TokenHelper.JwtOptions());

            //Route to Files in Foler wwwroot
            app.UseDefaultFiles();
            app.UseStaticFiles();
            var log = loggerFactory.CreateLogger("Config");

            app.UseMvc();
        }
    }
}
