using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek6.Class
{
    internal class Parrot:Pet,ISpeak,IFly
    {
        public Parrot(string name, string color, DateOnly bdate)
            : base("Папуга", name, color, bdate)
        {

        }
        public string fly()
        {
            return "Літаю зі швидкістю 10 км/г";
        }
        public string speak()
        {
            return "Попка дурак";
        }
    }
}
