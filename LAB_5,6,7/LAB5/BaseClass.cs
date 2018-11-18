using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    public abstract class PrintAdition
    {
        public string Name { get; set; }

        public PrintAdition ( string name)
        {
          this.Name=name;
        }

        public virtual void Print() // виртуальный метод
        {
            Console.WriteLine("Название издания: " + this.Name);
        }

        public abstract void Info(); //абстрактный метод
    }
}
