using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace LAB13
{
    class Program
    {
        static void Main(string[] args)
        {
            
                KPOLog log = new KPOLog();
                log.Call();

                KPOFileManager exp1 = new KPOFileManager();
                exp1.FileManager(@"C:\\Users\\Полина\\Desktop\\ун\\ООП\\oop1");
               
        }
    }
}
