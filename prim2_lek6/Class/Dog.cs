using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek6.Class
{
    internal class Dog:Pet
    {
        public Dog( string name, string color, DateOnly bdate) 
            : base("Собака", name, color, bdate)
        {
         
        }

        public override string run()
        {
            return "Бігу зі швидкістю 10 км/г";
        }
        public override string speak()
        {
            return "Гав гав";
        }
        public string guard()
        {
            return "Я охоронець";
        }
    }
}
