using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class SuperStack<T> : Stack<T>
    {
        public Stack<T> st { get; set; }

        public int StackCount => this.st.Count;

        public static bool operator == (SuperStack<T> stack1, SuperStack<T> stack2)
        {
                return stack1.Count.Equals(stack2.Count);
        }

        public static bool operator != (SuperStack<T> stack1, SuperStack<T> stack2)
        {
            return !stack1.Count.Equals(stack2.Count);
        }

        public override bool Equals(object a) //переопределение
        {
            if ( a == null)
            {
                return false;
            }
            if (a.GetType() != this.GetType())
            {
                return false;
            }
            Stack<T> temp = (Stack<T>)a;
            return this.Count == temp.Count;
        }

        public override int GetHashCode()
        {
            int hash;
            string wd = Convert.ToString(Count);
            hash = string.IsNullOrEmpty(wd) ? 0 : Count.GetHashCode();
            hash = (hash * 47) + Count.GetHashCode();
            return hash;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SuperStack<int> st1 = new SuperStack<int>();

            st1.Push(3);
            st1.Push(4);
            st1.Push(3);
            st1.Push(5);
            st1.Push(8);
            st1.Push(1);

            SuperStack<int> st2 = new SuperStack<int>();

            st2.Push(5);
            st2.Push(6);
            st2.Push(3);
            st2.Push(8);
            st2.Push(1);
            st2.Push(0);

            Console.WriteLine(st1.Equals(st2));
        }
    }
}
