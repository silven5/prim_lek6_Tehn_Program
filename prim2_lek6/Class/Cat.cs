using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek6.Class
{
    internal class Cat:Pet
    {
        public Cat(string name, string color, DateOnly bdate)
            : base("Кіт", name, color, bdate)
        {
            name = " Барсик";
        }

        public override string run()
        {
            return "Бігу зі швидкістю 15 км/г";
        }
        public override string speak()
        {
            return "Мяв мяв";
        }
        public string bringMouse()
        {
            return "Я ловлю мишей";
        }
    }
}
