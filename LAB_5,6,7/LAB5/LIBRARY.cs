using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Library
    {
        public List<PrintAdition> printAd = new List<PrintAdition>();
        public List<Book> book = new List<Book>();

        public int count = 0;

        public Book this[int index]
        {
            get
            {
                if (index > book.Count)
                {
                    Console.WriteLine("Превышен максимальный индекс списка печатных изданий");
                    return null;
                }
                return book[index];
            }
            set
            {
                if (index > book.Count)
                    Console.WriteLine("Элемента с таким индексом не существует");
                else
                    book[index] = value;
            }
        }

        public void AddPrintAd(PrintAdition P)
        {
            printAd.Add(P);
        }

        public void AddBook(Book P)
        {
            book.Add(P);
        }

        public void DelPrintAd(PrintAdition D)
        {
            printAd.Remove(D);
        }

        public void DelBook(Book D)
        {
            book.Remove(D);
        }

        
        public void PrintLibraryOfAdition()
        {
            Console.WriteLine("Список PrintAd: ");
            Console.WriteLine();
            for (int i = 0; i < printAd.Count; i++)
            {
                Console.WriteLine(printAd[i]);
                Console.WriteLine();
            }

        }

        public void PrintLibraryOfBook()
        {
            Console.WriteLine("Список Book: ");
            Console.WriteLine();
            for (int i = 0; i < book.Count; i++)
            {
                Console.WriteLine(book[i]);
                Console.WriteLine();
            }

        }



       
    }
}
