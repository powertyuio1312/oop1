using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.IO;

namespace LAB14
{
    class Program
    {
        static void Main(string[] args)
        {
            Book mybook1 = new Book(24,"NameOfBook1");
            Book mybook2 = new Book(11, "NameOfBook2");
            Book mybook3 = new Book(645, "NameOfBook3");
            Book mybook4 = new Book(243, "NameOfBook4");
            Book mybook5 = new Book(654, "NameOfBook5");
            Book mybook6 = new Book(111, "NameOfBook6");

            Console.WriteLine("Books created.");

            ///////// Бинарный
            Console.WriteLine("________BIN______");

            BinaryFormatter BinForm = new BinaryFormatter();

            using (FileStream fs = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                BinForm.Serialize(fs, mybook1);
                Console.WriteLine("Book serialized.");
            }

            using (FileStream fs = new FileStream("Book.dat", FileMode.OpenOrCreate))
            {
                Book newBook = (Book)BinForm.Deserialize(fs);
                Console.WriteLine("Book deserialized.");
                Console.WriteLine(mybook1.ToString());
            }

            /////////SOAP -  представляет простой протокол для обмена данными
            //между различными платформами.
            //При такой сериализации данные упакуются в конверт SOAP,
            //данные в котором имеют вид xml-подобного документа
            Console.WriteLine("_______SOAP_________");

            SoapFormatter SoapForm = new SoapFormatter();

            using (FileStream fs = new FileStream("Book.soap", FileMode.OpenOrCreate))
            {
                SoapForm.Serialize(fs, mybook2);
                Console.WriteLine("Book serialized.");
            }

            using (FileStream fs = new FileStream("Book.soap", FileMode.OpenOrCreate))
            {
                Book newBook = (Book)SoapForm.Deserialize(fs);
                Console.WriteLine("Book deserialized.");
                Console.WriteLine(mybook2.ToString());
            }


            /////////JSON
            Console.WriteLine("_______JSON_________");

            DataContractJsonSerializer JsonForm = new DataContractJsonSerializer(typeof(Book));

            using (FileStream fs = new FileStream("Book.json", FileMode.OpenOrCreate))
            {
                JsonForm.WriteObject(fs, mybook4);
                Console.WriteLine("Book serialized.");
            }

            using (FileStream fs = new FileStream("Book.json", FileMode.OpenOrCreate))
            {
                Book newBook = (Book)JsonForm.ReadObject(fs);
                Console.WriteLine("Book deserialized.");
                Console.WriteLine(mybook4.ToString());
            }


            /////////XML format
            Console.WriteLine("_______XML_________");


            //XmlSerializer XmlForm = new XmlSerializer(typeof(Book));

            //using (FileStream fs = new FileStream("Book.xml", FileMode.OpenOrCreate))
            //{
            //    XmlForm.Serialize(fs, mybook3);
            //    Console.WriteLine("Book serialized.");
            //}

            //using (FileStream fs = new FileStream("Book.xml", FileMode.OpenOrCreate))
            //{
            //    Book newBook = (Book)XmlForm.Deserialize(fs);
            //    Console.WriteLine("Book deserialized.");
            //    Console.WriteLine(mybook3.ToString());
            //}

            ////////////////////////////////////////////////////////

            List<Book> list = new List<Book>();
            list.Add(mybook1);
            list.Add(mybook2);
            list.Add(mybook3);
            list.Add(mybook4);
            list.Add(mybook5);
            list.Add(mybook6);
        }
    }
}
