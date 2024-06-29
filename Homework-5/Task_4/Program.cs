namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4, y = -2, z = 2, w = 3;

            if (x < y)
            {
                if (x < z)
                {
                    if (x < w)
                    {
                        Console.WriteLine("Smallest number is x");
                    }
                    else
                    {
                        Console.WriteLine("Smallest number is w");
                    }
                }
                else if (z < w)
                {
                    Console.WriteLine("Smallest number is z");
                }
            }
            else if (y < z)
            {
                if (y < w)
                {
                    Console.WriteLine("Smallest number is y");
                }
            }
        }
    }
}