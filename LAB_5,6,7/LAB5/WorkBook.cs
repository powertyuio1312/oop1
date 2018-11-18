using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class WorkBook : PrintAdition, IPublisher
    {
        private int Form;
        public const int COST = 300;
        public WorkBook(string Name, int Form): base(Name)
        {
            this.Form = Form;
        }

        public override string ToString()
        {
            return "" + base.ToString() + " The name of WorkBook is " + this.Name + ".";
        }


        public override void Print()
        {
            base.Print();
            Console.WriteLine("(Print)Учебник для {0} класса.", this.Form);
            Console.WriteLine("__________________________________");
        }

        public override void Info() // абстрактный метод 
        {
            Console.WriteLine("АБСТРАКТНЫЙ МЕТОД");
            Console.WriteLine("Учебник для {0} класса.", this.Form);
            Console.WriteLine();
        }

        void IPublisher.Info() // метод интерфейса
        {
            Console.WriteLine("МЕТОД ИНТЕРФЕЙСА");
            Console.WriteLine("Дата издания {0}", this.DateOfPublish);
            Console.WriteLine("__________________________________");
        }

        public int DateOfPublish { get; set; }
    }
}
