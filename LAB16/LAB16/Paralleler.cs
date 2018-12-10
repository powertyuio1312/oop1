using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace LAB16
{
    class Paralleler
    {
        public static void Generate(int n)
        {
            Vector vec = new Vector(n);
        }

        public static void Display()
        {
            Console.WriteLine("Current: {0}", Task.CurrentId);
            Thread.Sleep(3000);
        }

        public static void DoubleTask(int n)
        {
            Parallel.Invoke(Display, ()=>
            {
                Console.WriteLine("Current: {0}", Task.CurrentId);
                Thread.Sleep(300);
                Generate(n);
            },
                                                       ()=> Generate(n));
        }

        //For(int, int, Action<int>), 
        //где первый параметр задает начальный индекс элемента в цикле
        //второй параметр - конечный индекс
        //третий параметр - делегат Action - указывает на метод, который будет выполняться один раз за итерацию

        public static void For()
        {

            Stopwatch watch = new Stopwatch();

            watch.Start();
            Generate(10000);
            watch.Stop();
            Console.WriteLine("General cycle: {0}", watch.Elapsed);

            watch.Start();
            Parallel.For(1, 10000, Generate);
            watch.Stop();
            Console.WriteLine("Parallel cycle: {0}", watch.Elapsed);
        }

        //Foreach
        //ParallelLoopResult ForEach<TSource>(IEnumerable<TSource> source,Action<TSource> body)
        //где первый параметр представляет перебираемую коллекцию
        //второй параметр - делегат, выполняющийся один раз за итерацию для каждого перебираемого элемента коллекции.

        public static void ForEach()
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            foreach (int vec in new List<int>() { 10000, 10000 } )
            {
                Generate(vec);
            }

            watch.Stop();
            Console.WriteLine("General cycle: {0}", watch.Elapsed);

            watch.Start();
            ParallelLoopResult res = Parallel.ForEach<int>(new List<int>() { 10000, 10000 }, Generate);
            watch.Stop();
            Console.WriteLine("Parallel cycle: {0}", watch.Elapsed);
        }
    }
}
