using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Concurrent;
using System.Threading;

namespace LAB16
{

    class Program
    {
        static Task<int> FactorialAsync(int x)
        {
            int res = 1;
            return Task.Run(() =>
            {
                for (int i=0; i<= x; i++)
                {
                    res *= i;
                }
                return res;
            });
        }

        static async Task DisdlayResAsync() // (8)
        {
            int res = await FactorialAsync(32); // (8) приостановить выполнение метода, пока задача не завершится
            Thread.Sleep(3);
            Console.WriteLine("Number factorial {0} is {1}", 32, res);
        }

        static CancellationTokenSource cancelTokenSource = new CancellationTokenSource();

        static CancellationToken token = cancelTokenSource.Token;

        static void Main(string[] args)
        {
            


            Tasker.GetTask(10000000, 1);
            Tasker.GetTask(10000000, 2);
            Tasker.GetTask(10000000, 3);

            Task task = new Task(() => // 2
            {
                Tasker.GetTask(10000000, 64);
                if (token.IsCancellationRequested)
                {
                    return;
                }
            });

            Tasker.FourSum(new Vector(100), new Vector(40), new Vector(50)).GetAwaiter().GetResult(); // (4.2)

            Paralleler.For();
            Paralleler.ForEach();
            Paralleler.DoubleTask(1000000);

            Task t = DisdlayResAsync();
            t.Wait();
        }
    }
}
