using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1
{
    class Program
    {
        static void Main(string[] args)
        {
            // VAR 5

            //1a
            Console.WriteLine(System.Single.MaxValue); 

            //1b
            string str = "asdfghj";
            Console.WriteLine(str.Substring(2,2));
         
            //1c
            string[] list = new string[] { "A", "B", "C" };
            
            for (int i=0; i < list.Length; i++)
            {
                Console.WriteLine("List: {0}", list[i]);
            }

            //2
            Date date1 = new Date(6, 10, 2018);
            Date date2 = new Date(6, 10, 2018);
            Console.WriteLine(date1.GetHashCode() == date2.GetHashCode());

            //3
            people p1 = new people();
            ((ICan)p1).speak();
            Orator.Checker(p1);
        }
    }
}
