namespace Task_7
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int sum, product;
            GetSumAndProduct(num1, num2, out sum, out product);
            Console.WriteLine($"Sum of {num1} and {num2} is: {sum}");
            Console.WriteLine($"Product of {num1} and {num2} is: {product}");
        }
        public static void GetSumAndProduct(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }
    }

}
