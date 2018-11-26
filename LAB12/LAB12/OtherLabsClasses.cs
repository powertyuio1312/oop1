using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    interface IPublisher
    {
        int DateOfPublish { get; set; }
        void Info();
    }
    public abstract class PrintAdition
    {
        public string Name { get; set; }

        public PrintAdition(string name)
        {
            this.Name = name;
        }

        public virtual void Print() // виртуальный метод
        {
            Console.WriteLine("Название издания: " + this.Name);
        }

        public abstract void Info(); //абстрактный метод
    }
    class Book : PrintAdition, IPublisher
    {
        private int Pages;
        public const int COST = 100;
        public Book(int Pages, string Name) : base(Name)
        {
            this.Pages = Pages;

        }

          public override string ToString()
          {
              return "" + base.ToString() + " The name of Book is " + this.Name + ".";
          }
  
        public override void Print() // переопределение виртуального метода
        {
            base.Print();
            Console.WriteLine("(Print)Кол-во страниц: " + this.Pages);
            Console.WriteLine("__________________________________");
        }

        public override void Info() // абстрактный метод 
        {
            Console.WriteLine("АБСТРАКТНЫЙ МЕТОД");
            Console.WriteLine("(Info)Кол-во страниц: " + this.Pages);
            Console.WriteLine();
        }



        public int DateOfPublish { get; set; }

        void IPublisher.Info()// метод интерфейса
        {
            Console.WriteLine("МЕТОД ИНТЕРФЕЙСА");
            Console.WriteLine("Дата издания {0}", this.DateOfPublish);
            Console.WriteLine("__________________________________");
        }
    }

    public class Owner
    {
        public int ID;
        public string Name;
        public string Org;

        public Owner(int ID, string Name, string Org)
        {
            this.ID = ID;
            this.Name = Name;
            this.Org = Org;
        }

        public override string ToString()
        {
            return ID + ' ' + Name + ' ';
        }
    }
}
