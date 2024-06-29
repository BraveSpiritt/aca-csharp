namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hiEveryone = "  Hello World !  ";
            string helloEveryone = "*********Hello World !-----------------";

            char[] charsToTrim = { '*', '-' };

            Console.WriteLine($"Not trimmed - {hiEveryone}, trimmed - {hiEveryone.Trim()}");
            Console.WriteLine($"Not trimmed - {helloEveryone}, trimmed - {helloEveryone.Trim(charsToTrim)}");
        }
    }
}