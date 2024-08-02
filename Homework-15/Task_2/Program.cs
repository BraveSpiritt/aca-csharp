namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Bookshelf bookshelf1 = new Bookshelf();
            bookshelf1.Section = "Armenian Classics";
            bookshelf1.AddBook("The Book of Lamentations", "Grigor Narekatsi");
            bookshelf1.AddBook("The Gevorg Marzpetuni", "Muratsan");
            Bookshelf bookshelf2 = new Bookshelf();
            bookshelf2.Section = "Modern Armenian Literature";
            bookshelf2.AddBook("The Call of Plowmen", "Hovhannes Shiraz");
            bookshelf2.AddBook("The Song of the Bread", "Hovhannes Tumanyan");
            var library = new Library(new List<Bookshelf> { bookshelf1, bookshelf2 });
            foreach (var bookshelf in library)
            {
                Console.WriteLine($"Bookshelf: {bookshelf.Section}");
                foreach (var book in bookshelf)
                {
                    Book thisBook = book;
                    Console.WriteLine($"Title: {thisBook.Name}, Author: {thisBook.Author}");
                }
            }
        }
    }
}
