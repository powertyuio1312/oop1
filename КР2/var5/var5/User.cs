using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var5
{
    class User
    {
        public delegate void Delegat(Window a);

        public event Delegat OnMove;

        public void Move(Window a)
        {
            Console.WriteLine("размер до : {0}", a.size);
            if (OnMove != null)
            {
                a.Change();
                OnMove(a);
                Console.WriteLine("Движение мышкой, размер экрана изменен {0}", a.size);
            }
        }

    }
    class Window
    {
        public int size = 5;
        public void Change()
        {
            size--;
        }
    }
}
