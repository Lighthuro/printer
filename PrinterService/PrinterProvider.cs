using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Providers
{
    public class PrinterProvider : IPrinterProvider
    {
        //Must refactor
        [SupportedOSPlatform("windows")]
        public void UpdatePrinterStatus(Printer printer)
        {
            ManagementObject managementPrinter = new ManagementObjectSearcher($"SELECT * FROM Win32_Printer WHERE Name=\"{printer.Name}\"").Get().OfType<ManagementObject>().First();
            printer.SetStatut(Convert.ToInt32(managementPrinter["PrinterStatus"].ToString()));
        }

        public void Print(string executablePath, Printer printer)
        {
            string filePath = @"C:\Users\tarth\Documents\printerTest.pdf";
            ProcessStartInfo info= new ();
            info.FileName = filePath;
            info.Verb = "PrintTo";
            info.UseShellExecute = true;
            info.CreateNoWindow = false;
            //info.Arguments = $"\\\"{printer.Name}\"\\";
            info.Arguments = "\"" + printer.Name + "\"";
            Process.Start(info).WaitForExit();            
            Console.WriteLine("Impression terminé");
            Console.ReadKey();
        }
    }
}
