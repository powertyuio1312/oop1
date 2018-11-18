using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    //Вывести наименование всех книг в библиотеке, вышедших не ранее указанного года;
    //найти суммарное количество учебников в библиотеке,
    //Подсчитать стоимость изданий, находящихся в библиотеке.
    class ClassCONTROLER 
    {
        
        public void NameOfBookInLib(int year, Library obj)
        {
            Console.WriteLine("_____________");
            for (int i = 0; i < obj.book.Count; i++)
            {

                if (year >= obj.book[i].DateOfPublish)
                {
                    Console.WriteLine("Названия книг, изданых не раньше {0} года : {1}", year, obj.book[i].Name);
                }

            }

        }

        public void CountOfBook(Library obj)
        {
            Console.WriteLine("_____________");
            for (int i = 0; i < obj.printAd.Count; i++)
            {

                if (obj.printAd[i] is Book)
                {
                    obj.count++;
                    Console.WriteLine("Кол-во книг в библиотеке Изданий: {0}", obj.count);
                }

            }
        }

        public int cost = 0;
        public int CostOfAd(Library obj)
        {
            for (int i = 0; i < obj.printAd.Count; i++)
            {
                if (obj.printAd[i] is Book)
                {
                    cost = cost + Book.COST;
                }
                if (obj.printAd[i] is Magazin)
                {
                    cost = cost + Magazin.COST;
                }
                if (obj.printAd[i] is WorkBook)
                {
                    cost = cost + WorkBook.COST;
                }
            }
            Console.WriteLine("Цена всех книг: {0}", cost);
            return cost;
        }
    }
        
}
