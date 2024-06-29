namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15, b = 55, c = 38, d = 135;

            if (a > b && a > c && a > d)
            {
                Console.WriteLine("Largest value - a");
            }
            else if (b > a && b > c && b > d)
            {
                Console.WriteLine("Largest value - b");
            }
            else if (c > b && c > d && c > a)
            {
                Console.WriteLine("Largest value - c");
            }
            else
            {
                Console.WriteLine("Largest value - d");
            }
        }
    }
}