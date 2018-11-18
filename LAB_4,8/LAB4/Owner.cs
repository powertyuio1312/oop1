using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Owner
    {
        public int ID;
        public string Name;
        public string Org;

        public Owner(int ID, string Name, string Org)
        {
            this.ID = ID;
            this.Name = Name;
            this.Org = Org;
        }

        public override string ToString()
        {
            return ID + ' ' + Name + ' ';
        }
    }
}
