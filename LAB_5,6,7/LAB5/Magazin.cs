using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Magazin : PrintAdition, IPublisher, IElectronic
    {
        public const int COST = 150;
        private string Color;
        public Magazin(string Color, string Name ) : base(Name) // насл. из базового класса поля Name
        {
            this.Color = Color;
            
        }

        public override string ToString()
        {
            return "" + base.ToString() + " The name of Magazin is " + this.Name + ".";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("(Print)Цвет журнала: " + this.Color);
            Console.WriteLine("__________________________________");
        }

        public override void Info() // абстрактный метод 
        {
            Console.WriteLine("АБСТРАКТНЫЙ МЕТОД");
            Console.WriteLine("(Info)Цвет журнала: " + this.Color);
            Console.WriteLine();
        }

        void IPublisher.Info()// метод интерфейса
        {
            Console.WriteLine("МЕТОД ИНТЕРФЕЙСА");
            Console.WriteLine("Дата издания {0}", this.DateOfPublish);
            Console.WriteLine("Ссылка на журнал: {0}", this.LinkOnAdition);
            Console.WriteLine("__________________________________");
        }

        public int DateOfPublish { get; set; }

        public string LinkOnAdition { get; set; }
    }
}
