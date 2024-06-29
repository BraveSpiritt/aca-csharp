namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emptyString = " ";
            string nonEmptyString = "Hello World !";
            string onlyWhiteSpace = " ";

            Console.WriteLine($"Empty string - {String.IsNullOrEmpty(emptyString)},\nNon-empty string - {nonEmptyString}\nWhite space cheks - {String.IsNullOrWhiteSpace(onlyWhiteSpace)}");
        }
    }
}