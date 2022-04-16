using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public enum PrinterStatus
    {
        Other = 1,
        Unknown,
        Idle,
        Printing,
        Warmup,
        StoppedPrinting,
        Offline
    };
}
