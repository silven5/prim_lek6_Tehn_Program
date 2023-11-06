using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim6_lek6.Class
{
    internal class Library2 : IEnumerable

    {
        Book[] books;
        public Library2()
        {
            books = new Book[] { new Book("Вбити легко","Агата Кристі"),
        new Book("Гаррі Поттер","Дж. Роулінг"),
                    new Book("Гоббіт","Р.Р. Толкієн") };
        }
        public int Length
        {
            get { return books.Length; }
        }
        // повертаємо перерахувач
        IEnumerator IEnumerable.GetEnumerator()
        {
            return books.GetEnumerator();
        }

    }
}
