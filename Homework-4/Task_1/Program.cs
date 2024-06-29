namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello, World !";
            int lengthOfString = myString.Length;
            Console.WriteLine($"Length Of String: {lengthOfString},\nUppercased: {myString.ToUpper()},\nLowercased: {myString.ToLower()},\nSubstring: {myString.Substring(7)}");

            Console.ReadLine();
        }
    }
}