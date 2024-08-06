using System;
using System.Collections.Generic;
namespace Task_4
{
    public static class BookDataService
    {
        private static List<Book> books = new List<Book>
        {
            new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "9780743273565",
                Price = 10.99M,
                StockQuantity = 15,
                Description = "A novel set in the Roaring Twenties, exploring themes of wealth, society, and the American Dream.",
                Category = "Fiction"
            },
            new Book
            {
                Title = "A Brief History of Time",
                Author = "Stephen Hawking",
                ISBN = "9780553380163",
                Price = 15.99M,
                StockQuantity = 8,
                Description = "A landmark volume in science writing by one of the great minds of our time, exploring fundamental questions about the universe.",
                Category = "Science"
            },
            new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "9780061120084",
                Price = 12.49M,
                StockQuantity = 10,
                Description = "A novel about racial injustice in the Deep South, narrated by a young girl named Scout Finch.",
                Category = "Fiction"
            },
            new Book
            {
                Title = "Sapiens: A Brief History of Humankind",
                Author = "Yuval Noah Harari",
                ISBN = "9780062316110",
                Price = 18.99M,
                StockQuantity = 5,
                Description = "An exploration of the history of humankind, from the emergence of Homo sapiens to the present day.",
                Category = "Non-Fiction"
            },
            new Book
            {
                Title = "The Catcher in the Rye",
                Author = "J.D. Salinger",
                ISBN = "9780316769488",
                Price = 9.99M,
                StockQuantity = 12,
                Description = "A story about teenage rebellion and alienation, told through the eyes of Holden Caulfield.",
                Category = "Fiction"
            }
        };
        public static List<Book> GetBooks() => books;
        public static List<Book> GetBooksByCategory(string category)
        {
            return books.Where(book => book.Category == category).ToList();
        }
        public static Book GetBookDetails(string title)
        {
            return books.FirstOrDefault(book => book.Title == title);
        }
        public static void UpdateBookStock(Book book, int quantity)
        {
            var bookToUpdate = books.FirstOrDefault(b => b.ISBN == book.ISBN);
            if (bookToUpdate != null)
            {
                bookToUpdate.StockQuantity -= quantity;
            }
        }
    }
}
