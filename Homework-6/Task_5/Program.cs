
namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            {
                switch (userInput[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            Console.WriteLine($"Vowels count in {userInput} - {count}");
        }
    }
}
