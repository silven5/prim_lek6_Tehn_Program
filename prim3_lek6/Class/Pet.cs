using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek6.Class
{
    internal abstract class Pet
    {
        readonly string type;
        string name;
        readonly string color;
        readonly DateOnly bdate;

        public Pet(string type, string name, string color, DateOnly bdate)
        {
            this.type = type;
            this.name = name;
            this.color = color;
            this.bdate = bdate;
        }
        public string info()
        {
            return type + " " + name + " " + color + " " + bdate;
        }
    }
}
