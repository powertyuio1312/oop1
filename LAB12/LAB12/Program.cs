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
            
            Reflector.FieldsInfo(typeof(Owner));
            Reflector.InterfaceInfo(typeof(Owner));
            Reflector.MethodsInfo(typeof(Owner));

            Reflector.FieldsInfo(typeof(Owner));
            Reflector.InterfaceInfo(typeof(Book));
            Reflector.MethodsInfo(typeof(Book));
            
        }
    }
}
