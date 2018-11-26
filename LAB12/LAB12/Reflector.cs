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
    public static class Reflector
    {
        
        public static string InterfaceInfo(Type type) // интерфейсы
        {
            string InfInterf = "Interface info:  \r\n";

            Console.WriteLine("Реализованные интерфейсы:");
            foreach(Type i in type.GetInterfaces())
            {
                InfInterf += i.Name + "\r\n";
            }
            return InfInterf;
        }

        public static string MethodsInfo(Type type) // методы
        {
            string InfMethod = "Method Info: \r\n";

            Console.WriteLine("Реализованные публичные методы:");
            foreach (MethodInfo method in type.GetMethods())
            {
                string modif="";
                if (method.IsPublic)
                {
                    modif = "public";
                    InfMethod += modif + method.ReturnType.Name + " " + method.Name + "\r\n";
                }
               
            }
            return InfMethod;
        }

        public static string FieldsInfo(Type type)   // поля
        {
            string InfField = "Fields Info: \r\n";

            Console.WriteLine("Реализованные поля:");
            foreach (FieldInfo fields in type.GetFields())
            {
                InfField+= fields.FieldType + " " + fields.Name + "\r\n";
            }

            Console.WriteLine("Реализованные свойства:");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                InfField += prop.PropertyType+ " " + prop.Name + "\r\n";
            }
            return InfField;
        }

        public static string MethodParamInfo( Type param)//выводит по имени класса имена методов, которые содержат
                                                                //заданный(пользователем) тип параметра(имя класса
                                                                //передается в качестве аргумента);
        {
            Console.WriteLine("Введите тип параметра");
            string parametr = Console.ReadLine();
            string MethodParam = "Method with param Info: \r\n";

            bool flag = false;

            foreach (MethodInfo meth in param.GetMethods())
            {
                foreach (ParameterInfo par in meth.GetParameters())
                {
                    if (!parametr.Equals(par))
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    MethodParam += meth.Name + "\r\n";
                    flag = false;
                }
            }
            return MethodParam;
        }

       
        public static void InFile(Type type) //выводит всё содержимое класса в текстовый файл
                                                                                               
        {
            string FileName = type.Name + ".txt";
            using (StreamWriter SWfile = new StreamWriter(FileName))
            {
                SWfile.WriteLine(FieldsInfo(type));
                SWfile.WriteLine(InterfaceInfo(type));
                SWfile.WriteLine(MethodsInfo(type));
            }
        }
    }
}
