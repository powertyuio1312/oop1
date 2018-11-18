using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class CollectionType<T> : IOptions<T> where T:List , new() // обобщеный класс + обобщ интерфейс + ограничение 
    {
        List<T> t = new List<T>();
        
        public void Push(T obj)
        {
            this.t.Add(obj);
        }

        public void Pop1(T a)
        {
            if(this.t == null)
            {
                throw new Exception("Введено неверное значение");
            }
            this.t.Remove(a);
        }


        public void Show()
        {
            foreach (List i in t)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
