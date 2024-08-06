namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var fib in FibonacciSequence(100))
            {
                Console.Write(fib + " ");
            }
        }
        static IEnumerable<int> FibonacciSequence(int limit)
        {
            int a = 0, b = 1;
            while (a <= limit)
            {
                yield return a;
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
    }
}
