namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                int convertedNumber = userInput[i] - '0';
                if (convertedNumber % 2 != 0)
                {
                    sum += convertedNumber;
                }
            }
            Console.WriteLine("Result of sum {0}", sum);
        }
    }
}