using BusinessEntity;
using printer.Configurator;
using printer.Configurator.Windows;
using Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace printer
{
    internal class App
    {
        private readonly IPrinterProvider _PrinterProvider;

        public App(IPrinterProvider printerProvider)
        {
            this._PrinterProvider = printerProvider;
        }

        public void Run()
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
            Printer selectedPrinter = new();
            foreach (ManagementObject printer in printerConfigurator.PrintersInstalled)
            {
                Console.WriteLine($"- {printer["Name"]}; statut: {printer["PrinterStatus"]}");
                if (printer["Name"].ToString() == "HP8663BA (HP DeskJet 2700 series)")
                {
                    selectedPrinter = new()
                    {
                        Name = printer["Name"].ToString()
                    };
                }
            }
            while (true)
            {
                this._PrinterProvider.UpdatePrinterStatus(selectedPrinter);
                this._PrinterProvider.Print(printerConfigurator.PDFExecutablePath, selectedPrinter);
            }
        }
    }
}
