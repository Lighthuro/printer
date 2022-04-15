using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printer.Configurator
{
    public interface IPrinterConfigurator
    {
        public BasePrinterConfigurator LoadEnvironnementData();
    }
}
