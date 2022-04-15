using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printer.Configurator
{
    public class BasePrinterConfigurator
    {
        public List<string> PrintersInstalled { get; set; }
        public string PDFExecutablePath { get; set; }
    }
}
