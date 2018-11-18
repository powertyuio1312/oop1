using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public static class Printer
    {
            public static void IAmPrinting(PrintAdition PrA)
            {
                Console.WriteLine(PrA.GetType());
                Console.WriteLine(PrA.ToString());
            }
        
    }
}
