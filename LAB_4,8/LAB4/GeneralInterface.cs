using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    interface IOptions<T>
    {
        void Push(T obj);
        void Pop1(T a);
       // void Show();
        void Show();
    }
}
