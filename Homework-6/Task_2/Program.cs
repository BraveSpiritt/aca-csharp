namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int natNum = 15;
            int sum = 0;
            for (int i = 0; i < natNum + 1; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}