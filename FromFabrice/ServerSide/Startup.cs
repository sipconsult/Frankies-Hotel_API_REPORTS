using DevExpress.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServerSide.Services;
using static Microsoft.AspNetCore.Hosting.IWebHostEnvironment;

namespace ServerSide {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddDevExpressControls();
            services.Configure<CookiePolicyOptions>(options => {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            //services.AddCors();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.WithHeaders("Content-Type");
                });
            });
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseStaticFiles();
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();
           
            app.UseDevExpressControls();
            app.UseCookiePolicy();

            app.UseCors(options => {

                string devUrl = "http://localhost:3000";
                string devUrlBack = "http://localhost:3001";
                string productionEndUrl = "https/app.sipconsult.net/";
                //string productionEndUrl = "http://173.248.129.77,1439/";
                string devUrlBack_Frankies = "http://localhost";
                string productionEndUrl_Frankies = "http://3.74.54.13/,1439/";
                string url_Frankies = "http://3.74.54.13";

                options.WithOrigins(devUrl, productionEndUrl, devUrlBack, devUrlBack_Frankies, productionEndUrl_Frankies, url_Frankies)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
            });
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers().RequireCors("CorsPolicy");
                // ...
            });
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension.RegisterExtensionGlobal(new CustomReportStorageWebExtension(env));
        }
    }
}
