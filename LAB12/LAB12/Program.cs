using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflector refl1 = new Reflector("Lab12.Book");

            refl1.FieldsInfo();
            refl1.InterfaceInfo();
            refl1.MethodsInfo();
            refl1.MethodParamInfo();

            Reflector refl2 = new Reflector("Lab12.Owner");

            refl2.FieldsInfo();
            refl2.InterfaceInfo();
            refl2.MethodsInfo();
            refl2.MethodParamInfo();
            
        }
    }
}
