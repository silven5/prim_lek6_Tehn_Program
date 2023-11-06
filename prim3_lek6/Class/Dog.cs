using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek6.Class
{
    internal class Dog:Pet,ISpeak,IRun
    {
        public Dog(string name, string color, DateOnly bdate)
            : base("Собака", name, color, bdate)
        {

        }
       public  string run()
       {
           return "Бігу зі швидкістю 10 км/г";
        }
        public  string speak()
        {
            return "Гав гав";
        }
        public string guard()
        {
            return "Я охоронець";
        }
    }
}
