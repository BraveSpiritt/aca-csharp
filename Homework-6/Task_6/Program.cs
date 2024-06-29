namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorialNum = 7;
            int sum = 1;
            for (int i = 1; i < factorialNum + 1; i++)
            {
                sum *= i;

            }
            Console.WriteLine(sum);
        }
    }
}
