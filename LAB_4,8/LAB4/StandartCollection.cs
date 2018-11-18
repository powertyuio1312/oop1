using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class StandartCollection<T> 
    {
        public T id;
        
        public void Show(T a)
        {
            Console.WriteLine(a.ToString());
        }
    }
}
