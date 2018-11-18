using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LAB5
{
    
public class NullException: Exception
    {
       
        public NullException(string message) : base(message)
        {

        } 
       
        public void GetInfo()
        {
            Console.WriteLine("NullException {0}" + this.Message);
        }
    
    }

    public class EmptyException : Exception
    {
        public EmptyException(string message) : base(message)
        {

        }

        public void GetInfo()
        {
            Console.WriteLine("EmptyException {0}" + this.Message);
        }
    }



    [System.Serializable]
    public class UnChangableNameException : Exception
    {
        
        public UnChangableNameException()
        {
            Console.WriteLine("У объекта уже есть имя!");
        } // использует значение по умолчанию

        public UnChangableNameException(string message) : base(message)
        {
            Console.WriteLine("У объекта уже есть имя!");
        } //принимает строковое сообщ

        public UnChangableNameException(string message, Exception inner) : base(message, inner)
        {
            Console.WriteLine("У объекта уже есть имя!");
        } // принимает строковое сообщ или внутреннее исключение  
        
        protected UnChangableNameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class ObjectDateNotFoundException : Exception
    {
        public ObjectDateNotFoundException() { Console.WriteLine("Дата выхода книги не найдена!");  }
        public ObjectDateNotFoundException(string message) : base(message) { Console.WriteLine("Дата выхода книги не найдена!"); }
        public ObjectDateNotFoundException(string message, Exception inner) : base(message, inner) { Console.WriteLine("Дата выхода книги не найдена!"); }
        protected ObjectDateNotFoundException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
                
    
}
