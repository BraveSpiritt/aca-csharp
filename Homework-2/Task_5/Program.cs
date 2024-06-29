namespace Console_Title
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to change the console title.");
            Console.ReadKey();
            Console.Title = "Brand new title!";
            Console.ReadKey();
        }
    }
}