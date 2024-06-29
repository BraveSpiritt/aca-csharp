namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int guessNum = random.Next(0, 101);
            int guessCount = 8;
            Console.WriteLine("Let's start the game, enter number:");
            while (guessCount > 0)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                guessCount--;
                if (userInput == guessNum)
                {
                    Console.WriteLine("Congratulations, guess number is: {0}", guessNum);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong number, you have {0} attempt(s)", guessCount);
                    if (guessNum > userInput)
                    {
                        Console.WriteLine("Guess num is greater than {0}", userInput);
                    }
                    else
                    {
                        Console.WriteLine("Guess num is less than {0}", userInput);
                    }
                }
            }
            if (guessCount == 0)
            {
                Console.WriteLine("You lose, right number was {0} !", guessNum);
            }
        }
    }
}