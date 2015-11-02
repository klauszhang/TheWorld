﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using TheWorld.Services;
using Microsoft.AspNet.Hosting;

namespace TheWorld
{
  public class Startup
  {
    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services,IHostingEnvironment env)
    {
      services.AddMvc();

      if (env.IsDevelopment())
      {
        services.AddScoped<IMailService, DebugMailServices>();
      }
      else
      {
        // services.AddScoped<IMailService, RealMailServices>();
      }
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseStaticFiles();

      app.UseMvc(config=>
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
    }
  }
}
