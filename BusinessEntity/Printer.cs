using System;

namespace BusinessEntity
{
    public class Printer
    {
        public string Name { get; set; }
        public PrinterStatus Status { get; set; }

        public void SetStatut(int value)
        {
            this.Status = value switch
            {
                1 => PrinterStatus.Other,
                2 => PrinterStatus.Unknown,
                3 => PrinterStatus.Idle,
                4 => PrinterStatus.Printing,
                5 => PrinterStatus.Warmup,
                6 => PrinterStatus.StoppedPrinting,
                7 => PrinterStatus.Offline,
                _ => throw new IndexOutOfRangeException(),
            };
        }

    }
    
}
