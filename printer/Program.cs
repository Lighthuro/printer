using System;
using System.Management;
using Microsoft.Extensions.Hosting;
using printer.Configurator;
using printer.Configurator.Windows;
using Microsoft.Extensions.DependencyInjection;
using Providers;
using BusinessEntity;

namespace printer
{
    internal class Program
    {
        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((services) =>
                {
                    services.AddTransient<IPrinterProvider, PrinterProvider>();
                    services.AddSingleton<App>();
                });
        }


        private static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<App>().Run();
        }
    }
}