using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterService
{
    public interface IPrinter
    {
        public void Print(string filepath, string printer);
    }
}
