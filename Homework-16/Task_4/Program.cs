namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer { Name = "David", Email = "david.soghomonyan@bookstore.com" };
            List<Book> books = BookDataService.GetBooks();
            CustomerView.DisplayBooks(books);

            Console.WriteLine("Browse books by category:");
            CustomerView.DisplayBooksByCategory("Fiction");

            Console.WriteLine("View book details:");
            CustomerView.DisplayBookDetails("The Catcher in the Rye");

            Console.WriteLine("Add book to cart:");
            CustomerView.AddBookToCart(customer, "A Brief History of Time");

            Console.WriteLine("Place order:");
            CustomerView.PlaceOrder(customer);

            Console.WriteLine("View order history:");
            CustomerView.ViewOrderHistory(customer);
        }
    }
}
