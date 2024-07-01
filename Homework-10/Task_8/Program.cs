namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the position of the Fibonacci number you want to find:");
            int n = Convert.ToInt32(Console.ReadLine());

            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine($"The {n}th Fibonacci number is: {fibonacciNumber}");
        }
        static public int Fibonacci(int finishingPoint)
        {
            if (finishingPoint == 1)
            {
                return 0;
            }
            else if (finishingPoint == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(finishingPoint - 1) + Fibonacci(finishingPoint - 2);
            }
        }
    }
}
