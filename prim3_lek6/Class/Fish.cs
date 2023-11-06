using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek6.Class
{
    internal class Fish:Pet,ISweam
    {
        public Fish(string name, string color, DateOnly bdate)
           : base("Риба", name, color, bdate)
        {

        }
        public string sweam()
        {
            return "Я плавою зі швидкістю 12 км/г";
        }
    }
}
