using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterService
{
    public class AdobePdfPrinter:IPrinter
    {

        public string AdobeExecutablePath { get; set; }

        public void Print(string filepath, string printer)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
