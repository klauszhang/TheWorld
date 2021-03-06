﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using TheWorld.Services;
using Microsoft.AspNet.Hosting;
using Microsoft.Framework.Configuration;
using Microsoft.Dnx.Runtime;
using TheWorld.Models;
using Microsoft.Framework.Logging;
using Newtonsoft.Json.Serialization;

namespace TheWorld
{
  public class Startup
  {
    public static IConfigurationRoot Configuration;
    public Startup(IApplicationEnvironment appEnv)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(appEnv.ApplicationBasePath)
        .AddJsonFile("config.json")
        .AddEnvironmentVariables();

      Configuration = builder.Build();

    }

    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc()
        .AddJsonOptions(opt=>
        {
          opt.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        });

      services.AddLogging();

      services.AddEntityFramework()
        .AddSqlServer()
        .AddDbContext<WorldContext>();

      services.AddTransient<WorldContextSeedData>();

      services.AddScoped<IWorldRepository, WorldRepository>();
      // if (env.IsDevelopment())
      // IHostingEnvironment env
      // {
      services.AddScoped<IMailService, DebugMailServices>();
      // }
      //else
      //{
      //  // services.AddScoped<IMailService, RealMailServices>();
      //}
    }

    public void Configure(IApplicationBuilder app, WorldContextSeedData seeder,ILoggerFactory loggerFactory)
    {
      loggerFactory.AddDebug(LogLevel.Warning);

      app.UseStaticFiles();

      app.UseMvc(config =>
      {
        config.MapRoute(
            name: "Default",
            template: "{controller}/{action}/{id?}",
            defaults: new { controller = "App", action = "Index" }
            );
      });

      // Add the platform handler to the request pipeline.
      //app.UseIISPlatformHandler();

      //app.Run(async (context) =>
      //{
      //    await context.Response.WriteAsync("Hello World!");
      //});
      seeder.EnsureSeedData();
      
    }
  }
}
