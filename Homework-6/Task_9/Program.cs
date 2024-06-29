namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of levels for the pyramid: ");
            int levels = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= levels; i++)
            {
                for (int j = 1; j <= levels - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}