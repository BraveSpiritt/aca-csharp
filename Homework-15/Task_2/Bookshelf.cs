using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Bookshelf : IEnumerable<Book>
    {
        public string Section { get; set; }
        private readonly List<Book> books = new List<Book>();
        public void AddBook(string name, string author)
        {
            books.Add(new Book { Name = name, Author = author });
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new Librarian(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
