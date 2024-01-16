using SIP_NightAudit_Service.Service.HimsModels;
using SIP_NightAudit_Service.Service.Interfaces;
using SIP_NightAudit_Service.Service.RxModels;
using SIP_NightAudit_Service.Service.ServiceModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Log = Serilog.Log;
using SIP_NightAudit_Service.ServiceModels;

namespace SIP_NightAudit_Service.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {

           


            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .Enrich.FromLogContext()
                //.WriteTo.File("C:\\Temp\\HimsService\\ServiceLog\\log.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.File("C:\\Temp\\HimsSetupService\\ServiceLog\\log.txt", rollingInterval: RollingInterval.Day)
                //.WriteTo.File("C:\\Temp\\HimsSupportService\\ServiceLog\\log.txt", rollingInterval: RollingInterval.Day)
                //.WriteTo.File("D:\\3D Object backup\\HIMSDATA\\HIMSDATA\\HimsData.Service\\ServiceLog\\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();


            try
            {
                Log.Information("Worker Service has started");
                Console.WriteLine("Worker Service has started");
                CreateHostBuilder(args).Build().Run();
            }
            catch(Exception ex)
            {
                Log.Fatal(ex, "Worker Service Have some errors");
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Log.CloseAndFlush();
            }
          
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 .UseWindowsService()
                .ConfigureServices((hostContext, services) =>
                {
                    IConfiguration configuration = hostContext.Configuration;

                    AppSettings.Configuration = configuration;
                    //AppSettings.RxConnectionString = configuration.GetConnectionString("RxDBConnectionString");
                    //AppSettings.HimsConnectionString = configuration.GetConnectionString("HimsDBConnectionString");
                    AppSettings.HotelConnectionString = configuration.GetConnectionString("DefaultConnection");

                    var optionBuilder = new DbContextOptionsBuilder<FrankiesHotelContext>();
                    optionBuilder.UseSqlServer(AppSettings.HotelConnectionString);

                    services.AddScoped<FrankiesHotelContext>(d => new FrankiesHotelContext(optionBuilder.Options));

                    //var optionBuilder1 = new DbContextOptionsBuilder<HimsDBContext>();
                    //optionBuilder1.UseSqlServer(AppSettings.HimsConnectionString);

                    //services.AddScoped<HimsDBContext>(d => new HimsDBContext(optionBuilder1.Options));


                    services.AddHostedService<Worker>();
                })
                .UseSerilog()
                ;
    }
}
