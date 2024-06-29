namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"Multiplication of {i}");
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");

                }
            }
        }
    }
}