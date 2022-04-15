using System;
using printer.Configurator;
using printer.Configurator.Windows;

namespace printer
{
    internal class Program
    {
        
        private static void Main()
        {
            BasePrinterConfigurator printerConfigurator;
            if (OperatingSystem.IsWindows())
            {
                printerConfigurator = new WindowsPrinterAdobeConfigurator().LoadEnvironnementData();
            }
            else
            {
                throw new NotSupportedException();
            }
            Console.WriteLine($"Adobe installation path: {printerConfigurator.PDFExecutablePath}\n\nprinters installed:");
            printerConfigurator.PrintersInstalled.ForEach((printerName) => Console.WriteLine($"- {printerName}"));
            
        }

    }
}