namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int pcValue = random.Next(0, 3);
            Console.Write("Let's play rock - paper - scissors, (rock - 1, paper - 2, scissors - 3) enter your value: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            string[] arr = { "rock", "paper", "scissors" };
            result = playerChoice - pcValue;


            if (playerChoice == pcValue)
            {
                Console.WriteLine("Draw !");
            }
            else if (playerChoice == 3 && pcValue == 2)
            {
                Console.WriteLine("PC choose - paper, You win !");
            }
            else if (playerChoice == 3 && pcValue == 1)
            {
                Console.WriteLine("PC choose - rock, PC wins !");
            }
            else if (playerChoice == 2 && pcValue == 1)
            {
                Console.WriteLine("PC choose - rock, You win !");
            }
            else if (playerChoice == 2 && pcValue == 3)
            {
                Console.WriteLine("PC choose - scissors, PC wins !");
            }
            else if (playerChoice == 1 && pcValue == 3)
            {
                Console.WriteLine("PC choose - scissors, You win !");
            }
            else if (playerChoice == 1 && pcValue == 2)
            {
                Console.WriteLine("PC choose - paper, PC wins !");
            }

        }
    }
}