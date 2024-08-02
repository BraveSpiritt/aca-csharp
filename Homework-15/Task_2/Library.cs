using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Library : IEnumerable<Bookshelf>
    {
        private List<Bookshelf> bookshelves;
        public Library(List<Bookshelf> bookshelves)
        {
            this.bookshelves = bookshelves;
        }

        public IEnumerator<Bookshelf> GetEnumerator()
        {
            return new LibraryEnumerator(bookshelves);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
