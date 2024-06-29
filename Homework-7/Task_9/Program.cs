namespace Task_9
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();
            char separator = ' ';
            Console.Write("Enter word: ");
            string searchingWord = Console.ReadLine();
            string[] words = sentence.Split(separator);
            int count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == searchingWord)
                {
                    count++;
                }
            }
            Console.WriteLine("{0} appears {1} times", searchingWord, count);
        }
    }
}