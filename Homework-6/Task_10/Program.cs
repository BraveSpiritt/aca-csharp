namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}