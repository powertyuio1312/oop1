using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LAB_10
{
    class Observ
    {
        ArrayList arr = new ArrayList();

        public delegate void Deleg(string str);

        public event Deleg OnChange;

        public void Add(object obj)
        {
            arr.Add(obj);
            if (OnChange != null)
            {
                OnChange("Some Changes!!!!!!!!");
            }
        }

        public void Del(object obj)
        {
            arr.Remove(obj);
            if (OnChange != null)
            {
                OnChange("Some Changes!!!!!!!!");
            }
        }

        public void show(string str)
        {
            Console.WriteLine(str);
        }

        public void On()
        {
            this.OnChange += this.show;
        }
    }
}
