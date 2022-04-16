using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Management;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace printer.Configurator.Windows
{
    internal static class WindowsPrinterConfigurator
    {

        [SupportedOSPlatform("windows")]
        internal static List<string> LoadInstalledPrintersNames()
        {
            List<string> printers = new();
            foreach (string printerName in PrinterSettings.InstalledPrinters)
            {
                printers.Add(printerName);
            }
            return printers;
        }

        [SupportedOSPlatform("windows")]
        internal static ManagementObjectCollection LoadInstalledPrinters()=>new ManagementObjectSearcher("SELECT * FROM Win32_Printer").Get();
    }
}
