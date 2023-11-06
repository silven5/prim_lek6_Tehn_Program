using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim6_lek6.Class
{
    internal class Library
    {       Book[] books;
            public Library()
            {
                books = new Book[] { new Book("Вбити легко","Агата Кристі"),
        new Book("Гаррі Поттер","Дж. Роулінг"),
                    new Book("Гоббіт","Р.Р. Толкієн") };
            }
            public int Length
            {
                get { return books.Length; }
            }
            public Book this[int index]
            {
                get
                {
                    return books[index];
                }
                set
                {
                    books[index] = value;
                }
            }
        }
   

}

