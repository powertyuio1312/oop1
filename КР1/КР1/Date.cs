using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КР1
{
    class Date
    {
        public int day, month, year;
        public int Day
        {
            get
            {
                if (day >= 31)
                {
                    return 31;
                }
                else if (day <= 1)
                    return 1;
                else return day;
                
            }
            set
            {
                day = value;
            }
        }

        public int Month
        {
            get
            {
                if (month <= 1)
                    return 1;
                else if (month >= 12)
                    return 12;
                else return month;

            }
            set
            {
                month = value;
            }
        }

        public int Year
        {
            get
            {
                if (year <= 1)
                    return 1;
                else if (year >= 2018)
                    return 2018;
                else return year;

            }
            set
            {
                year = value;
            }
        }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
            Console.WriteLine("Date: {0}.{1}.{2}", this.day, this.month, this.year);
        }

        public override int GetHashCode()
        {

            return base.GetHashCode();
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;
        //    if (obj.GetType() != this.GetType())
        //        return false;
        //    Date date =  Date(day, month, year);
        //    return obj.day == this.day;
        //}
    }
}
