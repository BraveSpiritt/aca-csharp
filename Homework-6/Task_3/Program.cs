namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string reversedString = "";

            for (int i = 1; i < userInput.Length + 1; i++)
            {
                Console.WriteLine($"last letter: {userInput[userInput.Length - i]}");
                reversedString += userInput[userInput.Length - i];
            }
            Console.WriteLine(reversedString);
        }
    }
}