using Microsoft.Win32;
using System.Runtime.Versioning;

namespace printer.Configurator.Windows
{
    [SupportedOSPlatform("windows")]
    public class WindowsPrinterAdobeConfigurator: BasePrinterConfigurator, IPrinterConfigurator
    {
        private const string keyName = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Adobe\\Adobe Acrobat\\DC\\Installer";

        public BasePrinterConfigurator LoadEnvironnementData()
        {
            this.PDFExecutablePath=(string)Registry.GetValue(keyName, "Acrobat.exe", "no such key");
            this.PrintersInstalled = WindowsPrinterConfigurator.LoadInstalledPrinters();
            return this;
        }


    }
}