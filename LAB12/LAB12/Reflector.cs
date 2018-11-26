using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;

namespace LAB12
{
    public class Reflector
    {
        public Type type;

        public Reflector (string type)
        {
            this.type = Type.GetType(type, false, true);
        }

        public void InterfaceInfo() // интерфейсы
        {
           

            Console.WriteLine("Реализованные интерфейсы:");
            foreach(Type i in type.GetInterfaces())
            {
                Console.WriteLine( i.Name + "\r\n");
            }
        }

        public void MethodsInfo() // методы
        {
            Console.WriteLine("Реализованные публичные методы:");
            foreach (MethodInfo method in type.GetMethods())
            {
                string modif="";
                if (method.IsPublic)
                {
                    modif = "public ";
                    Console.WriteLine( modif + method.ReturnType.Name + " " + method.Name + "\r\n");
                }
               
            }
        }

        public void FieldsInfo()   // поля
        {
            Console.WriteLine("Реализованные поля:");
            foreach (FieldInfo fields in type.GetFields())
            {
                Console.WriteLine( fields.FieldType + " " + fields.Name + "\r\n");
            }

            Console.WriteLine("Реализованные свойства:");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                Console.WriteLine( prop.PropertyType+ " " + prop.Name + "\r\n");
            }
        }

        public void MethodParamInfo()//выводит по имени класса имена методов, которые содержат
                                                                //заданный(пользователем) тип параметра(имя класса
                                                                //передается в качестве аргумента);
        {
            Console.WriteLine("Введите тип параметра");
            string parametr = Console.ReadLine();

            bool flag = false;

            foreach (MethodInfo meth in type.GetMethods())
            {
                foreach (ParameterInfo par in meth.GetParameters())
                {
                    if (!parametr.Equals(par))
                    {
                        flag = true;
                    }
                    if (flag)
                    {
                        Console.WriteLine(meth.Name + " " + meth.ReturnParameter + "\r\n");
                        flag = false;
                    }
                }
                
            }
        }

       
        //public static void InFile(Type type) //выводит всё содержимое класса в текстовый файл
                                                                                               
        //{
        //    string FileName = type.Name + ".txt";
        //    using (StreamWriter SWfile = new StreamWriter(FileName))
        //    {
        //        SWfile.WriteLine(FieldsInfo(type));
        //        SWfile.WriteLine(InterfaceInfo(type));
        //        SWfile.WriteLine(MethodsInfo(type));
        //    }
        //}
    }
}
