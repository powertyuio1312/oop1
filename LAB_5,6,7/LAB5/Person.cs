using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    partial class Person 
    {
        public string FirstName;
        public string SecondName;

        /// <summary>
        /// ///////////////////////////////////
        /// </summary>
        /// 
        public Persons persons;

        public Person (Persons persons)
        {
            this.persons = persons;
        }

        public void PrintInf()
        {
            Console.WriteLine(persons);
            Console.WriteLine("_____________________");
        }

        /// <summary>
        /// ////////////////////////
        /// </summary>

        public Person(string FirstName, string SecondName)
        {
            this.FirstName = FirstName;
            this.SecondName = SecondName;
        }

        public override string ToString()   //переопределение метода(во всех классах)
        {
            return "Type " + base.ToString() + ". The person - " + FirstName + " " + SecondName + ".";
        }
        
    }
}
