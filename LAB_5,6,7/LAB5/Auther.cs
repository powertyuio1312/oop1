using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    sealed class Auther : Person // бесплодный класс
    {
       
        public string CityOfAuther;
        public Auther(string FirstName, string SecondName, string CityOfAuther) : base(FirstName, SecondName)
        {
            this.CityOfAuther = CityOfAuther;
            Console.WriteLine("Автор: " + this.FirstName + " " + this.SecondName);
            Console.WriteLine("Город автора: " + this.CityOfAuther);
        }

        
    }
}
