using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class List
    {
        public Owner owner;

        public List()
        {
            this.MyList = new List<int>();
            this.owner = new Owner(1, "Polina Kosovets", "BSTU");
        }

        public List<int> MyList { get; set; }

        public int Count => this.MyList.Count;

        public void Push(int elem) => this.MyList.Add(elem); // добавление элемента

        public int Pop() // удаление элемента
        {
            int LastElemIndex = this.MyList.Count - 1;
            int LastElem = this.MyList[LastElemIndex];
            this.MyList.RemoveAt(LastElemIndex);
            return LastElem;
        }
        public int Remove(int pos) // удаление элемента с заданой позиции
        {
            this.MyList.RemoveAt(pos);
            return pos;
        }

        public static List operator >> (List list, int pos)//удалить элемент в заданной позиции
        {
            list.Remove(pos); 
            return list;
        }

        public static List operator + (List list, int elem) //добавить элемент в заданную позицию
        {
            list.Push(elem);
            return list;
        }

        public static bool operator ==(List list1, List list2) //проверка на равенствомножеств
        {
            return list1.Equals(list2);
        }

        public static bool operator != (List list1, List list2) //проверка на неравенствомножеств
        {
            return !list1.Equals(list2);
        }

        //если перегружаются операторы == и !=, то для этого требуется переопределить методы Object.Equals() и Object.GetHashCode().

        public override bool Equals(object list) //переопределение
        {
            if (list == null)
            {
                return false;
            }
            if (list.GetType() != this.GetType())
            {
                return false;
            }
            List temp = (List)list;
            return this.Count == temp.Count && this.MyList == temp.MyList;
        }
        public override int GetHashCode()
        {
            int hash;
            string wd = Convert.ToString(Count);
            hash = string.IsNullOrEmpty(wd) ? 0 : Count.GetHashCode();
            hash = (hash * 47) + Count.GetHashCode();
            return hash;
        }
        public override string ToString()
        {
            return this.owner.Name + "- owner of "+ this.MyList + " : " + this.MyList.Count;
        }

        public class Date // Вложенный класс
        {
            private int day, month, year;
            public int Day
            {
                get
                {
                    return day;
                }
                set
                {
                    if (day < 1)
                        day = 1;
                    else if (day > 31)
                        day = 31;
                    
                }
            }
            public int Month
            {
                get
                {
                    return month;
                }
                set
                {
                    if (month < 1)
                        month = 1;
                    else if (month > 12)
                        month = 12;
                }
            }
            public int Year
            {
                get
                {
                    return year;
                }
                set
                {
                    if (year < 1)
                        year = 1;
                    else if (year > 2018)
                        year = 2018;
                }
            }

            public Date(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
        }

        //индексатор
        public int this[int index]
        {
            get
            {
                return this.MyList[index];
            }

            set
            {
                this.MyList[index] = value;
            }

       }

     }
}
