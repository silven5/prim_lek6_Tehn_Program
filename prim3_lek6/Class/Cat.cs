using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim3_lek6.Class
{
    internal class Cat:Pet,ISpeak,IRun
    {
        public Cat(string name, string color, DateOnly bdate)
           : base("Кіт", name, color, bdate)
        {
            name = " Барсик";
        }

        public  string run()
        {
            return "Бігу зі швидкістю 15 км/г";
        }
        public string speak()
        {
            return "Мяв мяв";
        }
        public string bringMouse()
        {
            return "Я ловлю мишей";
        }
    }
}
