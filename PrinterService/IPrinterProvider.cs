using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Providers
{
    public interface IPrinterProvider
    {
        public void Print(string executablePath, Printer printer);
        public void UpdatePrinterStatus(Printer printer);
    }
}
