namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 1, c = 3;

            if (a == b && a == c)
            {
                Console.WriteLine("The triangle is equilateral");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("The triangle is isoscales");
            }
            else
            {
                Console.WriteLine("The triangle is scalene");
            }
        }
    }
}