using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class LibraryEnumerator : IEnumerator<Bookshelf>
    {
        private List<Bookshelf> bookshelves;
        private int position = -1;

        public LibraryEnumerator(List<Bookshelf> bookshelves)
        {
            this.bookshelves = bookshelves;
        }

        public Bookshelf Current
        {
            get
            {
                try
                {
                    return bookshelves[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            position++;
            return (position < bookshelves.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}
