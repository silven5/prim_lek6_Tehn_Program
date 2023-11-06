using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim6_lek6.Class
{
    internal class Library3
    {
        Book[] books;
        public Library3()
        {
            books = new Book[] { new Book("Вбити легко","Агата Кристі"),
        new Book("Гаррі Поттер","Дж. Роулінг"),
                    new Book("Гоббіт","Р.Р. Толкієн") };
        }
        public int Length
        {
            get { return books.Length; }
        }
        public IEnumerable GetBooks()
        {
            for (int i = 0; i < Length; i++)
            {
                if (i == books.Length)
                {
                    yield break;
                }
                else
                {
                    yield return books[i];
                }
            }
        }

    }
}
