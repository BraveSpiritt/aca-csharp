namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            switch (a)
            {
                case 1:
                    Console.WriteLine("Option 1 selected");
                    break;
                case 2:
                    Console.WriteLine("Option 2 selected");
                    break;
                case 3:
                    Console.WriteLine("Option 3 selected");
                    break;
                case 4:
                    Console.WriteLine("Option 4 selected");
                    break;
                case 5:
                    Console.WriteLine("Option 5 selected");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}