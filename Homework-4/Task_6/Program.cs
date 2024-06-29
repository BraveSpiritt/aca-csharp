namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string incorrectSentence = "I love programming in Java";
            string correctSentence = incorrectSentence.Replace("Java", "C#");
            Console.WriteLine(correctSentence);
        }
    }
}