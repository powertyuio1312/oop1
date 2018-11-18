using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LAB_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student("NameOfStud", 3);
            ArrayList arr1 = new ArrayList();

            Random rand = new Random();
            int[] temp = new int[5];
            for (int i=0; i<5;i++)
            {
                temp[i] = rand.Next(10);
                arr1.Add(temp[i]);
            }

            arr1.Add(stud);

            arr1.Add("Striiiiing");

            arr1.Remove(arr1[3]);

            foreach( object o in arr1)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine(arr1.Contains(stud));

            //////////////////////////////////////////

            LinkedList<char> list = new LinkedList<char>();

            list.AddFirst('A');
            list.AddAfter(list.First, 'B');
            list.AddLast('D');
            list.AddBefore(list.Last, 'C');
            list.AddLast('I');

            list.Remove(list.First);

            Console.WriteLine("LinkedList: ");
            foreach( char ch in list)
            {
                Console.WriteLine(ch);
            }

            /////////////////////////////////////////

            HashSet<char> hashset = new HashSet<char>();
            Console.WriteLine("HashSet: ");
            foreach ( char ch in list)
            {
                hashset.Add(ch);
                Console.WriteLine(ch);
            }

            Console.WriteLine("Содержит ли HashSet заданное значение? {0}", hashset.Contains('C'));

            ///////////////////////////////////////

            Console.WriteLine("_________________________________________________Наблюдаемая коллекция.");

            Observ ob = new Observ();

            ob.Add(5);
            ob.Add(7);
            ob.Add("striiiing");

            ob.On();

            ob.Del(7);
            ob.Add(23);
        }
    }
}
