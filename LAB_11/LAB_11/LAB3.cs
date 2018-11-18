using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11
{
    class LAB3
    {
    }
    public class Rectangle
    {
        private int height;
        private int width;
        private double diagonal;
        private double diagonal2;
        public readonly int ronly; //поле только для чтения
        private const string e = "Invalid value!";  //константа
        static int objct;   //статичекое поле
        public string type;
        public int Ug;
        public Rectangle()  //3 конструктора(с, без, по умолчанию)
        {
            height = 17;
            width = 17;
            diagonal = 9;
            diagonal2 = 19;
            type = "romb";
            ronly = GetHashCode();
            objct++;
        }
        public Rectangle(int height, int width, int Ug) // diag - необяз. параметр
        {
            this.Height = height;
            this.Width = width;
            this.Ug = Ug;
            objct++;
        }
        static Rectangle()  //статический
        {
            objct = 0;
        }
        public int Width    //свойства для полей
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(e);
                }
                else
                {
                    width = value;
                }
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(e);
                }
                else
                {
                    height = value;
                }
            }
        }
        public double Diagonal
        {
            get
            {
                return diagonal;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(e);
                }
                else
                {
                    diagonal = value;
                }
            }
        }
        public double Diagonal2
        {
            get
            {
                return diagonal2;
            }
            private set //ограничен доступ
            {
                if (value <= 0)
                {
                    Console.WriteLine(e);
                }
                else
                {
                    diagonal2 = value;
                }
            }
        }
        public override bool Equals(object obj) //переопределение
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Rectangle temp = (Rectangle)obj;
            return this.height == temp.height && this.width == temp.width;
        }

        public override int GetHashCode()
        {
            int hash;
            string wd = Convert.ToString(width);
            hash = string.IsNullOrEmpty(wd) ? 0 : width.GetHashCode();
            hash = (hash * 47) + height.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return "Type " + base.ToString() + " " + width + " " + height + " ";
        }

        public double Romb(ref double d1, out double d2)    //ref и out-параметры
        {
            double romb;
            d2 = d1 + 2;
            d1++;
            romb = 0.5 * d1 * d2;
            return romb;
        }

        public double square()
        {
            return this.width * this.height;
        }

        public double perimetre()
        {
            return (this.width + this.height)*2;
        }

        public static void Info(Rectangle cl)   //статический метод
        {
            Console.WriteLine("ИНФОРМАЦИЯ О КЛАССЕ Rectangle:");
            Console.WriteLine("Количество объектов: " + objct);
            Console.WriteLine("Ширина сторон: " + cl.width);
            Console.WriteLine("Длина сторон: " + cl.height);
            Console.WriteLine("Длина первой диагонали: " + cl.diagonal);
            Console.WriteLine("Длина второй диагонали: " + cl.diagonal2);
            Console.WriteLine("Площадь: " + cl.Romb(ref cl.diagonal, out cl.diagonal2));
            Console.WriteLine("Длина первой диагонали:(1) " + cl.diagonal);
            Console.WriteLine("Длина второй диагонали(2): " + cl.diagonal2);
        }
    }
    public partial class Calculations   //частичный класс
    {
        private Calculations()  //закрытый конструктор, нельзя создавать экземпляр
        { }
        public static int Perimeter(int width, int height)
        {
            int p;
            p = 2 * (width + height);
            return p;
        }
    }
    public partial class Calculations
    {
        public static int Area(int width, int height)
        {
            int a;
            a = width * height;
            return a;
        }
    }
}
