using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace LAB16
{
    class Store
    {
        public static BlockingCollection<int> store;

        public static void Producer()
        {
            for (int i=0; i<=10;i++)
            {
                store.Add(i);
                Console.WriteLine("Producer: " + i);
            }
            store.CompleteAdding();
        }

        public static void Customer()
        {
            int i;
            while (!store.IsCompleted)
            {
                if (store.TryTake(out i))
                {
                    Console.WriteLine("Customer: " + i);
                }
            }
        }

        public static void StoreWork()
        {
            store = new BlockingCollection<int>(5);
            Task Pr = new Task(Producer);
            Task Cm = new Task(Customer);

            Pr.Start();
            Cm.Start();

            try
            {
                Task.WaitAll(Cm, Pr);
            }
            catch
            {
                Console.WriteLine("Exeption!!!!!!!!!!");
            }
            finally
            {
                Cm.Dispose(); //даже в случае возникновения исключения
                                //произойдет освобождение ресурсов в методе Dispose.
                Pr.Dispose();
                store.Dispose();
            }
        }
    }
}
