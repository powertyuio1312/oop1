using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace LAB_11
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________1______________________");
            string[] month = {"January", "February", "Martch", "April", "May", "June", "July", "Augest", "September", "October", "November", "December" };

            IEnumerable<string> nameL = month.Where(m => m.Length < 5); // запрос месяцев по длине строки , СИНТАКСИС ЗАПРОСОВ

            //IEnumerable<int> nameLeng = from m in month ТЕКУЧИЙ СИНТАКСИС
            //                            select m.Length;

            Console.WriteLine("( m.Length < 5 ):");
            foreach ( string i in nameL)
            {
                Console.WriteLine(" \t {0}",i);
            }


            IEnumerable<string> AlfName = month.OrderBy(a => a); // по алфавиту

            Console.WriteLine("По алфавиту:");
            foreach (string item in AlfName)
            {
                Console.WriteLine(" \t {0}", item);
            }

            
            IEnumerable<string> WinterM = month.Take(2).Concat(month.Skip(11)); // Зимние месяцы

            Console.WriteLine("Winter Month:");
            foreach (string w in WinterM)
            {
                Console.WriteLine(" \t {0}", w);
            }


            string[] SummerM = { "June", "July", "Augest" }; // Летние месяцы

            Console.WriteLine("Summer Month:");
            foreach (string s in month.Intersect(SummerM))
            {
                Console.WriteLine(" \t {0}", s);
            }

            IEnumerable<string> U = month.Where(m => m.Contains("u")).Where(m => m.Length > 4); // Содержит u и длина > 4

            Console.WriteLine("U + Length > 4 :");
            foreach (string u in U)
            {
                Console.WriteLine(" \t {0}", u);
            }

            Console.WriteLine("____________________2______________________");

            List<Rectangle> list = new List<Rectangle>();

            list.Add(new Rectangle(10, 10, 90));
            list.Add(new Rectangle(20, 30, 30));
            list.Add(new Rectangle(25, 13, 90));
            list.Add(new Rectangle(17, 17, 90));
            list.Add(new Rectangle(14, 40, 120));

            IEnumerable<Rectangle> quadrat = from q in list
                                             where q.Width == q.Height && q.Ug == 90
                                             select q;
            
            IEnumerable<Rectangle> romb = from r in list
                                                   where r.Width != r.Height && r.Ug != 90
                                                   select r;
            IEnumerable<Rectangle> rectangle = from re in list
                                               where re.Width != re.Height && re.Ug == 90
                                               select re;

            Console.WriteLine("МIN площадь квадрата:");
            double MinSqKvad = quadrat.Min(p => p.square());
            Console.WriteLine(MinSqKvad);

            Console.WriteLine("MAX площадь квадрата:");
            double MaxSqKvad = quadrat.Max(p => p.square());
            Console.WriteLine(MaxSqKvad);


            Console.WriteLine("МIN периметр ромба:");
            double MinSqRomb = romb.Min(p => p.perimetre());
            Console.WriteLine(MinSqRomb);

            Console.WriteLine("MAX периметр ромба:");
            double MaxSqRomb = romb.Max(p => p.perimetre());
            Console.WriteLine(MaxSqRomb);


            Console.WriteLine("МIN площадь прямоугольника:");
            double MinSqRect = rectangle.Min(p => p.square());
            Console.WriteLine(MinSqRect);

            Console.WriteLine("MAX площадь прямоугольника:");
            double MaxSqRect = rectangle.Max(p => p.square());
            Console.WriteLine(MaxSqRect);

            Console.WriteLine("Квадраты со стороной не более 15: ");
            IEnumerable<Rectangle> Kvad = from n in quadrat
                                          where n.Width < 15
                                          select n;          
            foreach (Rectangle d in Kvad)
            {
                Console.WriteLine(d.Width);
            }

            IEnumerable<double> rectangles = rectangle.Select(p => p.perimetre());

            foreach (double r in rectangles)
            {
                Console.WriteLine("Упорядоченный массив rectangle: {0}", r);
            }

            //
            Console.WriteLine("____________________3-4______________________");

            var animal = new[]
            {
                new {id = 1, Nature = "Home", Name = "Cat"  },
                new {id = 2, Nature = "Wild", Name = "Jaguare" },
                new {id = 3, Nature = "Home", Name = "Dog" },
                new {id = 4, Nature = "Wild", Name = "Wolf" },
                new {id = 5, Nature = "Wild", Name = "Fox" }
            };

            IEnumerable<string> SortAnimal = animal.Where(a => a.id < 4)
                .Where(p => p.Nature.Equals("Home"))
                .Where(v => v.Name.StartsWith("C"))
                .Select(n => n.Name);

            Console.WriteLine("После запросов:");
            foreach (string z in SortAnimal)
            {
                Console.WriteLine(" \t {0}", z);
            }

            Console.WriteLine("____________________5______________________");

            string[] anim = { "Cat", "Dog", "Fox", "Wolf" };
            int[] key = { 1, 3, 7, 4 };

            var any = anim.Join(key, w => w.Length,q => q, (w, q) => new
                {
                    id = w,
                    AnimalNameLength = string.Format("{0}", q),
                }
                );

            Console.WriteLine("После Join:");
            foreach (var item in any)
            {
                Console.WriteLine(" \t {0}", item);
            }
        }
    }
    /// LINQ - набор языковых и платформенных средств для написания структурированных,
    ///безопасных в отношении типов запросов к локальным коллекциям объектов и
    ///удаленным источникам данных (последовательность + элемент)
    ///
    ///Лямбда-выражение, которое принимает значение и возвращает результат
    ///типа bool, называется предиkатом.
    ///
    /// Агрегирования: Count, Min (Скалярные значения)
    /// Квантификаторы: Contains,Any (bool)
    /// Над элементами: First, ElementAt
    /// 

    ///Операция Select используется для создания выходной последовательности одного типа элементов из входной последовательности элементов другого типа. Эти типы не обязательно должны совпадать.
    ///Операция Take возвращает указанное количество элементов из входной последовательности, начиная с ее начала.
    ///Операция Skip пропускает указанное количество элементов из входной последовательности, начиная с ее начала, и выводит остальные.
    ///Операция Concat соединяет две входные последовательности и выдает одну выходную последовательность. 
    ///Операция OrderBy позволяет упорядочить входную последовательность на основе метода keySelector, который возвращает значение ключа для каждого входного элемента.
    ///Операция Join выполняет внутреннее соединение по эквивалентности двух последовательностей на основе ключей, извлеченных из каждого элемента этих последовательностей.
    ///Операция Distinct удаляет дублированные элементы из входной последовательности.
    ///Операция Union (соединение множеств с удаление дубликатов) возвращает объединение множеств из двух исходных последовательностей.
    ///Операция Intersect возвращает пересечение множеств из двух исходных последовательностей.
}
