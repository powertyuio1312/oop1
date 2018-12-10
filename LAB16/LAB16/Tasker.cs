using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace LAB16
{
    class Tasker
    {
        public static void GetTask(int size, int num)
        {
            Stopwatch watch = new Stopwatch(); // 1.2
            watch.Start();

            Vector vec = new Vector(size);

            Task task = Task.Factory.StartNew(() => vec = vec * num);
            Console.WriteLine("STATUS: " + task.Status); //1.1

            task.Wait();//Чтобы указать, что метод Main должен подождать до конца выполнения задачи,
                        //нам надо использовать метод Wait

            watch.Stop();

            Console.WriteLine(watch.Elapsed);
        }

        public static async Task FourSum(Vector one, Vector two, Vector three)
        {
            Task<int> task1 = new Task<int>(() => one.Sum());
            task1.Start();

            Task<int> task2 = new Task<int>(() => two.Sum());
            task2.Start();

            Task<int> task3 = new Task<int>(() => three.Sum());
            task3.Start();

            Task<Vector> task4 = new Task<Vector>(() => new Vector(task1.Result + task2.Result + task3.Result));

            Task task5 = task4.ContinueWith(Display); // ContinueMith (4.1)

            task4.Start();
            task5.Wait(); //Чтобы указать, что метод Main должен подождать до конца выполнения задачи,
                          //нам надо использовать метод Wait

            Console.WriteLine(task4.Result.Sum());
        }

        public static void Display(Task task)
        {
            Console.WriteLine("ID now: {0}", Task.CurrentId);
            Console.WriteLine("TD before: {0}", task.Id);
            Thread.Sleep(3000);
        }
    }
}
