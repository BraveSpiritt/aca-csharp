namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            GenerateAndPrintPrimes(n);
        }

        public static void GenerateAndPrintPrimes(int n)
        {
            int count = 0;
            int number = 2;
            while (count < n)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    count++;
                }
                number++;
            }
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            if (number % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
