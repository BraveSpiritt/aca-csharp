using System;

namespace Task_4
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Order> OrderHistory { get; set; } = new List<Order>();
        public ShoppingCart ShoppingCart { get; set; } = new ShoppingCart();
    }
    public class Order
    {
        public List<Book> Books { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
    }
    public class ShoppingCart
    {
        public List<Book> Books { get; set; }

        public ShoppingCart()
        {
            Books = new List<Book>();
        }
    }
}
