using System.Collections;

namespace Task_2
{
    internal class Librarian : IEnumerator<Book>
    {
        private List<Book> books;
        private int position = -1;

        public Librarian(List<Book> books)
        {
            this.books = books;
        }
        public Book Current
        {
            get
            {
                try
                {
                    return books[position];
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
            return (position < books.Count);
        }
        public void Reset()
        {
            position = -1;
        }

        public void Dispose() { }
    }
}


