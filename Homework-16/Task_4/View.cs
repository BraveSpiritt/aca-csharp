using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public static class CustomerView
    {
        public static void DisplayBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"ISBN: {book.ISBN}");
                Console.WriteLine($"Price: {book.Price:C}");
                Console.WriteLine($"Stock: {book.StockQuantity}");
                Console.WriteLine($"Description: {book.Description}");
                Console.WriteLine($"Category: {book.Category}");
                Console.WriteLine(new string('-', 20));
            }
        }

        public static void DisplayBooksByCategory(string category)
        {
            var books = BookDataService.GetBooksByCategory(category);
            if (books.Any())
            {
                DisplayBooks(books);
            }
            else
            {
                Console.WriteLine($"No books found in the category: {category}");
            }
        }

        public static void DisplayBookDetails(string title)
        {
            var book = BookDataService.GetBookDetails(title);
            if (book != null)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"ISBN: {book.ISBN}");
                Console.WriteLine($"Price: {book.Price:C}");
                Console.WriteLine($"Stock: {book.StockQuantity}");
                Console.WriteLine($"Description: {book.Description}");
                Console.WriteLine($"Category: {book.Category}");
                Console.WriteLine(new string('-', 20));
            }
            else
            {
                Console.WriteLine($"Book with title {title} not found.");
            }
        }

        public static void AddBookToCart(Customer customer, string title)
        {
            var book = BookDataService.GetBookDetails(title);
            if (book != null && book.StockQuantity > 0)
            {
                customer.ShoppingCart.Books.Add(book);
                Console.WriteLine($"Book {title} added to the cart.");
            }
            else
            {
                Console.WriteLine($"Book {title} is out of stock or does not exist.");
            }
        }

        public static void RemoveBookFromCart(Customer customer, string title)
        {
            var book = customer.ShoppingCart.Books.FirstOrDefault(b => b.Title == title);
            if (book != null)
            {
                customer.ShoppingCart.Books.Remove(book);
                Console.WriteLine($"Book {title} removed from the cart.");
            }
            else
            {
                Console.WriteLine($"Book {title} not found in the cart.");
            }
        }

        public static void PlaceOrder(Customer customer)
        {
            if (!customer.ShoppingCart.Books.Any())
            {
                Console.WriteLine("Shopping cart is empty. Cannot place order.");
                return;
            }

            var order = new Order
            {
                Books = new List<Book>(customer.ShoppingCart.Books),
                OrderDate = DateTime.Now,
                TotalPrice = customer.ShoppingCart.Books.Sum(b => b.Price)
            };

            foreach (var book in order.Books)
            {
                BookDataService.UpdateBookStock(book, 1);
            }

            customer.OrderHistory.Add(order);
            customer.ShoppingCart.Books.Clear();
            Console.WriteLine("Order placed successfully!");
            Console.WriteLine($"Order Date: {order.OrderDate}");
            Console.WriteLine($"Total Price: {order.TotalPrice:C}");
            Console.WriteLine("An order confirmation email has been sent to your email.");
        }

        public static void ViewOrderHistory(Customer customer)
        {
            if (!customer.OrderHistory.Any())
            {
                Console.WriteLine("No orders found.");
                return;
            }

            foreach (var order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Date: {order.OrderDate}");
                Console.WriteLine($"Total Price: {order.TotalPrice:C}");
                foreach (var book in order.Books)
                {
                    Console.WriteLine($"- {book.Title} by {book.Author}");
                }
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
