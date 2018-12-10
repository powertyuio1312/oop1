using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var3
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperLinkedList<string> ss = new SuperLinkedList<string>();
            try
            {
                ss.Add("1");
                ss.AddPoslednii("2");
                ss.AddPoslednii("3");
                ss.AddPoslednii("4");



                ss.DelFir();
                ss.DelFir();
                ss.DelFir();
                ss.DelFir();
                ss.DelFir();
            }
            catch
            {
                Console.WriteLine("Нет элемента");
            }
        }



        public class SuperLinkedList<T> : LinkedList<T>
        {
            LinkedList<T> ll = new LinkedList<T>();

            public void Add(T num)
            {
                ll.AddFirst(num);
                Console.WriteLine("Added {0}", num);
            }

            public void AddPoslednii(T num)
            {
                ll.AddLast(num);
                Console.WriteLine("Added last {0}", num);
            }
            public void DelFir()
            {
                ll.RemoveFirst();
                Console.WriteLine("Delited");
            }
        }
    }
}
