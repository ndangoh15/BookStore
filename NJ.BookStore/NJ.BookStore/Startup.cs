using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NJ.BookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (Context, next) =>
            //    {
            //        await Context.Response.WriteAsync("This is my first middleware\n");

            //        await next();

            //        await Context.Response.WriteAsync("Response from first middleware\n");
            //    });

            //app.Use(async (Context, next) =>
            //{
            //    await Context.Response.WriteAsync("This is my second middleware\n");
            //     await next();
            //    await Context.Response.WriteAsync("Response from second middleware\n");
            //});

            //app.Use(async (Context, next) =>
            //{
            //    await Context.Response.WriteAsync("This is my third middleware\n");

            //});
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/joe", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Joe");
            //    });
            //});
        }
    }
}
