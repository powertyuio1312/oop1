using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            List MyList1 = new List();
            List MyList2 = new List();
            List MyList3 = new List();


            MyList1 = MyList1 + 12;
            MyList1 = MyList1 + 4;
            MyList1 = MyList1 + 76;
            MyList1 = MyList1 + 7;
            MyList1 = MyList1 + 2;
            MyList1 = MyList1 + 712;

            // Console.WriteLine("Count of MyList1 = " + MyList1.Count);
            // Console.WriteLine("MyList1 : ");
            // for (int i = 0; i < MyList1.Count; i++)
            // {
            //     Console.WriteLine(MyList1[i]);
            // }

            // Console.WriteLine("_______________________________");

            MyList2 = MyList2 + 8;
            MyList2 = MyList2 + 1;
            // Console.WriteLine("Count of List2: " + MyList2.Count);
            // Console.WriteLine("List2: ");
            // for (int i = 0; i < MyList2.Count; i++)
            // {
            //     Console.WriteLine(MyList2[i]);
            // }

            // Console.WriteLine("_______________________________");

            // MyList3 = MyList1 >> 1; //удаление элемента в заданной позиции
            // Console.WriteLine("List3: ");
            // for (int i = 0; i < MyList3.Count; i++)
            // {
            //     Console.WriteLine(MyList3[i]);
            // }

            // Console.WriteLine("_______________________________");

            // Console.WriteLine("Проверка на равенство множеств List1 и List2 : " + (MyList1 != MyList2));    //проверка на неравенство множеств

            // Console.WriteLine("_______________________________");

            ///// удаление последнего элемента и возврат количества элементов списка
            // Console.WriteLine("Delete last element of List3 and count of List3: " + MathOperation.CountOfEl(MathOperation.DelLastWord(MyList3)));
            // Console.WriteLine("List3: ");
            // for (int i = 0; i < MyList3.Count; i++)
            // {
            //     Console.WriteLine(MyList3[i]);
            // }

            // Console.WriteLine("_______________________________");

            //// нахождение мах и мин элементов
            // Console.WriteLine("\nMin element of List1: " + MathOperation.SearchMIN(MyList1));
            // Console.WriteLine("Max element of List2: " + MathOperation.SearchMAX(MyList2));

            // Console.WriteLine("_______________________________");

            //int k;
            //string[] array = { "Red", "Black", "Blue", "Green", "Purple" }; //нахождение самого длинного слова
            //k = MathOperation.SearchTheLongest(array);
            //Console.WriteLine("Element with max length of array: " + array[k]);

            //Console.WriteLine("_______________________________");

            //Console.WriteLine("Owner: {0} {1} {2}", MyList1.owner.ID, MyList1.owner.Name, MyList1.owner.Org);

            //List.Date date = new List.Date(15, 10, 2018);
            //Console.WriteLine("Creation date: {0}.{1}.{2}", date.Day, date.Month, date.Year);

            //////////////////////////////////////////////  8 LAB
            Console.WriteLine("---------------------------------- 8 LAB -------------------------------");

            try
            {
                StandartCollection<int> Coll = new StandartCollection<int>();
                Coll.id = 7;
                Coll.Show(Coll.id);
                Console.WriteLine("_______________________________");

                StandartCollection<string> Coll2 = new StandartCollection<string>();
                Coll2.id = "7";
                Coll2.Show(Coll2.id);
                Console.WriteLine("_______________________________");

                CollectionType<List> Collection = new CollectionType<List>();
                MyList1.Push(1);
                Console.WriteLine("MyList1.Count: {0}", MyList1.Count);
                Collection.Push(MyList1);
                Collection.Push(MyList2);
                Collection.Push(MyList3);

                //Collection.Pop1(MyList2);

                Collection.Show();
                ///////

                //StandartCollection<Owner> Set = new StandartCollection<Owner>();
                //Set.set.Add(new Owner(4, "Kate", "Org"));
                //Set.set.Add(new Owner(5, "Sasha", "Org2"));
                //Set.Show(Set.set[2]);




            }
            catch (FormatException)
            {
                Console.WriteLine("Неверно введенные данные!");
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка в логике задаваемых параметров объектов");
            }
            finally
            {
                
                Console.WriteLine("Stop Exceptions!");
                Console.ReadKey();
            }

        }
    }
}
