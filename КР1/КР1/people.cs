using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1
{
    public class people: ICan
    {
        void ICan.speak()
        {
            Console.WriteLine(" I Can speak");
        }

    }

    public static class Orator
    {
        public static void Checker(people people)
        {
            if (people is ICan)
                ((ICan)people).speak();
        }
    }
}
