using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var5
{
    class Program
    {
        static void Main(string[] args)
        {
            //3
            Window a = new Window();
            Window b = new Window();

            User u = new User();

            u.OnMove += o_onmove;

            u.Move(a);
            u.Move(b);

            Console.WriteLine();
            //1
            SuperQueue<DateTime> sq = new SuperQueue<DateTime>();
            sq.Add(new DateTime());
            sq.Add(new DateTime());
            sq.Add(new DateTime());
            sq.Add(new DateTime());
            sq.Add(new DateTime());

           

            //2

            string[] mass = { "Aaa", "Bbbbb", "Ccc", "FF", "Iii" };

            var three = mass.Where(l => l.Length == 3);

            foreach (string s in three)
            {
                Console.WriteLine(s);
                Console.WriteLine();
            }

            //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            //Point p = new Point();
            //p.x = 1;
            //p.y = 2;

            //p.useDelegates();

            

        }



        public static void o_onmove(Window a)
        {
            Console.WriteLine("Обработчик");
        }


       


        //public class Point
        //{
        //    public delegate void dclear();
        //    public delegate int dsum();

        //    public int x;
        //    public int y;

        //    public void Clear()
        //    {
        //        this.x = 0;
        //        this.y = 0;
        //    }

        //    public int GetSum()
        //    {
        //        return this.x + this.y;
        //    }

        //    public void useDelegates()
        //    {
        //        dclear clear = Clear;
        //        dsum sum = GetSum;

        //        Console.WriteLine(sum());
        //        clear();
        //        Console.WriteLine(sum());
        //    }
        //}
    }
}

