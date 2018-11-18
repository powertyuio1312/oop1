using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Журнал, Книга, Печатное издание, Учебник,
//Персона, Автор, Издательство.


namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book MyBook = new Book(123, "First Book");
            Book MyBook2 = new Book(12, "Sec Book");

            Magazin MyMagazin = new Magazin("Черный", "VOGUE");

            WorkBook MyWorkBook = new WorkBook("Математика", 11);

            if (MyBook is PrintAdition)
            {
                Console.WriteLine(" MyBook is PrintAdition ");
                MyBook.Print();
            }

            if (MyBook2 is Book)
            {
                Console.WriteLine("MyBook2 is Book");
                MyBook2.Print();
            }

            if (MyMagazin is Book)
            {
                MyMagazin.Print();
            }
            else
            {
                Console.WriteLine("MyMagazin не  Book!!!");
            Console.WriteLine("__________________________________");
        }



            // вызов одноименных методов

            MyMagazin.DateOfPublish = 2012;
            MyMagazin.LinkOnAdition = "http//.......";
            MyMagazin.Info();
            ((IPublisher)MyMagazin).Info();

            Console.WriteLine();

            MyBook.DateOfPublish = 2018;
            MyBook.Info();
            ((IPublisher)MyBook).Info();

            Console.WriteLine();

            MyBook2.DateOfPublish = 1993;
            MyBook2.Info();
            ((IPublisher)MyBook2).Info();

            MyWorkBook.DateOfPublish = 2017;
            MyWorkBook.Info();
            ((IPublisher)MyWorkBook).Info();


            PrintAdition[] mass = { MyBook, MyBook2, MyMagazin as Magazin, MyWorkBook };
            for (int i=0; i<mass.Length;i++)
            {
                Printer.IAmPrinting(mass[i]);
            }

            Console.WriteLine("____________________________");
            IPublisher one = new Book(1678, "Third Book");
            Console.WriteLine(one is Book);
            Console.WriteLine("-------------------------------------------------------------------------------------");

            //////////////////////////////// 6LAB


            Console.WriteLine("________________ 6 LAB __________________");
            // стркутура

            Publishes StBook;
            StBook.auther = "Auther";
            StBook.name = "NameOfBook";

            Publishes StMagazin;
            StMagazin.name = "NameOfStMagazin";
            StMagazin.auther = "Auther";

            // перечисления

            Person NewPerson1 = new Person (Persons.Customer);
            Person NewPerson2 = new Person(Persons.Reader);
            Person NewPerson3 = new Person(Persons.Writer);

            NewPerson1.PrintInf();
            NewPerson2.PrintInf();
            NewPerson3.PrintInf();

            //////////////////////////////////////

            Library library1 = new Library();
            Library library2 = new Library();

            library1.AddBook(MyBook);
            library1.AddBook(MyBook2);

            library1.PrintLibraryOfBook();
            
            library2.AddPrintAd(MyMagazin);
            library2.AddPrintAd(MyWorkBook);
            library2.AddPrintAd(MyBook2);
            library2.AddPrintAd(MyBook);

            library2.PrintLibraryOfAdition();

            Console.WriteLine("После удаления книги: ");
            library2.DelPrintAd(MyBook2);
            library2.PrintLibraryOfAdition();

            /////////////////

            ClassCONTROLER contr = new ClassCONTROLER();

            contr.NameOfBookInLib(2001, library1); //названия книг опред. года
            Console.WriteLine();

            contr.CountOfBook(library2); // кол-во нкниг в библ
            Console.WriteLine();
            
            contr.CostOfAd(library2); // цена всех изданий в библ
            Console.WriteLine();
            //-------------------------------------------------------------------------------------
            // 7 Lab

            Console.WriteLine("_________________________ 7 LAB _____________________________");

            try
            {
                object o = null;
                o.ToString();

                string st = "После исключения..";
                Console.WriteLine(st);
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Обнаружение NullReferenceException. ");
            }
            catch(NullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally..");
            }
            Console.WriteLine();

            try
            {
                
                for ( int i=8; i>-2;i--)
                {
                    i = 10 / i;
                    if (i == 0)
                        throw new DivideByZeroException();
                }
                Console.WriteLine("После исключения..");

            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally..");
            }
            Console.WriteLine();

            // пользовательские исключения
            Book MyBook3 = new Book(234, "Name the third book");
            try
            {
                if (MyBook3.Name != null)
                    throw new UnChangableNameException();
                else
                    MyBook.Name = "New Name";
            }
            catch (UnChangableNameException)
            {
                Console.WriteLine();
            }
            finally
            {
                MyBook3.Info();
            }

            Console.WriteLine();

            /*      Book MyBook4 = new Book(53, "Name the forth book");
                  MyBook4.DateOfPublish = 789;
                  Console.WriteLine("Дата выхода книги инт {0}", MyBook4.DateOfPublish);
                  Console.WriteLine("Дата выхода книги строка {0}", MyBook4.DateOfPublish.ToString());
      */

            Book MyBook4 = new Book(53, "Name the forth book");
            try
            {
                if (MyBook4.DateOfPublish == 0)
                {
                    throw new ObjectDateNotFoundException();
                }
                else
                    MyBook4.Info();
            }
            catch(ObjectDateNotFoundException)
            {
                Console.WriteLine();
            }
            finally
            {
                MyBook4.Info();
            }

            Book MyBook5 = new Book(24,"name");
            MyBook5.DateOfPublish = 2005;
            Debug.Assert(MyBook5.DateOfPublish == 2004, "Неверный год.");

        }
    }
}
