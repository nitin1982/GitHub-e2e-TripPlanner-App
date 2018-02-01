using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TripPlanner.DAL;
using TripPlanner.RepositoriesUoW;
using TripPlanner.ServiceContracts;
using TripPlanner.Services;

namespace TripPlanner.TripPlannerAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<TripPlannerEntities>(_ => new TripPlannerEntities(@"data source=(localdb)\MSSQLLocalDB;initial catalog=TripPlannerDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"));

            services.AddScoped<ITripPlannerUoW, TripPlannerUoW>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddScoped<IPictureService, PictureService>();
            services.AddScoped<IRefernceService, ReferenceService>();
            services.AddScoped<ITripImportantDatesService, TripImportantDatesService>();
            services.AddScoped<ITripService, TripService>();
            services.AddScoped<IWebLinkService, WebLinkService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
