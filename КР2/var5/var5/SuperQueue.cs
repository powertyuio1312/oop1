using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var5
{
    class SuperQueue<T> where T : struct
    {
        Queue<T> qqq = new Queue<T>();

        public void Add(T el)
        {
            try
            {
                if (qqq.Count <= 3)
                {
                    qqq.Enqueue(el);
                    Console.WriteLine("Added.");
                }
                else
                    throw new Exception();
            }
            catch
            {
                Console.WriteLine("Exception");
            }
        }
    }
}
