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
using System.Xml.Linq;

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
            Console.WriteLine("____________________________BIN______");

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
            Console.WriteLine("________________________________SOAP_________");

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
            Console.WriteLine("____________________________________JSON_________");

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
            Console.WriteLine("____________________________________XML_________");
            
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

            Console.WriteLine("________________________________________LIST_______");
            
            List<Book> list = new List<Book>();
            list.Add(mybook1);
            list.Add(mybook2);
            list.Add(mybook3);
            list.Add(mybook4);
            list.Add(mybook5);
            list.Add(mybook6);

            BinaryFormatter ListBinForm = new BinaryFormatter();

            using (FileStream fs = new FileStream("List.dat", FileMode.OpenOrCreate))
            {
                foreach (Book b in list)
                {
                    ListBinForm.Serialize(fs, b);
                }
                Console.WriteLine("List serialized.");
            }

            using (FileStream fs = new FileStream("List.dat", FileMode.OpenOrCreate))
            {
                Book newbook = (Book)ListBinForm.Deserialize(fs);
                Console.WriteLine("List deserialized.");
                foreach (Book b in list)
                {
                    Console.WriteLine(b.ToString());
                }
            }

            //////////////////////////////////////
            Console.WriteLine("________________________________________XPath for XML__________");

            

            ////////////////////////////////////
            Console.WriteLine("_______________________________________Link to XML(or Json)______________");

            XDocument xdoc = new XDocument();

            // 1 element
            XElement Cat = new XElement("animal");

            XAttribute CatNameAttr = new XAttribute("name", "Mary");

            XElement CatYear = new XElement("year", "1.5");
            XElement CatType = new XElement("type", "maine coon");

            Cat.Add(CatNameAttr);
            Cat.Add(CatYear);
            Cat.Add(CatType);

            //2 element 
            XElement Dog = new XElement("animal");

            XAttribute DogNameAttr = new XAttribute("name", "Bob");

            XElement DogYear = new XElement("year", "4");
            XElement DogType = new XElement("type", "Kolly");

            Dog.Add(DogNameAttr);
            Dog.Add(DogYear);
            Dog.Add(DogType);

            //root element
            XElement animals = new XElement("ANIMALS");

            animals.Add(Cat);
            animals.Add(Dog);

            //Add el in doc
            xdoc.Add(animals);

            xdoc.Save("animals.xml");

            // output
            XDocument xdoc1 = XDocument.Load("animals.xml");

            foreach(XElement item in xdoc1.Element("ANIMALS").Elements("animal"))
            {
                XAttribute nameAttr1 = item.Attribute("name");
                XElement animalYear = item.Element("year");
                XElement animalType = item.Element("type");

                if (nameAttr1 != null && animalType != null && animalYear != null)
                {
                    Console.WriteLine("Animal Name: {0}", nameAttr1.Value);
                    Console.WriteLine("Year: {0}", animalYear.Value);
                    Console.WriteLine("Type: {0}", animalType.Value);
                    Console.WriteLine();
                }
            }

            // Linq

            Console.WriteLine();
            Console.WriteLine("LINQ:");

            XDocument xdoc2 = XDocument.Load("animals.xml");

            var items = from xEl in xdoc2.Element("ANIMALS").Elements("animal")
                        where xEl.Element("year").Value == "4"
                        select new Animal
                        {
                            Name = xEl.Attribute("name").Value,
                            Year = xEl.Element("year").Value
                        };

            foreach (var item in items)
            {
                Console.WriteLine("{0} -- {1}", item.Name, item.Year);
            }

        }



    }
    class Animal
    {
        public string Name { get; set; }
        public string Year { get; set; }
    }

}
