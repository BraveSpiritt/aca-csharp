
namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 10.5;
            double b = 7.2;
            double c = 15.8;
            double d = 12.3;
            double e = 9.6;
            double largest = a;
            double smallest = a;

            if (b > largest)
                largest = b;
            else if (b < smallest)
                smallest = b;

            if (c > largest)
                largest = c;
            else if (c < smallest)
                smallest = c;
            if (d > largest)
                largest = d;
            else if (d < smallest)
                smallest = d;
            if (e > largest)
                largest = e;
            else if (e < smallest)
                smallest = e;
            Console.WriteLine($"Largest number: {largest}");
            Console.WriteLine($"Smallest number: {smallest}");
        }
    }
}
