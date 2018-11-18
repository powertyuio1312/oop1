using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_9
{
    public class StringUpdates
    {
        public  StringUpdates(string str)
        {
            Console.WriteLine(str);
        }

        public void Low(string str)
        {
            str = str.ToLower();
        }

        public void Upp(string str)
        {
            str = str.ToUpper();
        }

        public void Change(string str)
        {
            str = str.Replace(" ", ".");
        }
    }
}
