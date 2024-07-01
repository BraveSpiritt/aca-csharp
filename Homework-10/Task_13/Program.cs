namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "This is an example sentence, without any meaning.";
            string[] words = SplitStringIntoWords(sentence);

            Console.WriteLine("Words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
        public static string[] SplitStringIntoWords(string sentence)
        {
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words;
        }
    }
}
