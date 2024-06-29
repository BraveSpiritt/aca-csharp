namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            Console.Write("Enter 50 inegers:");
            for (int i = 0; i < 51; i++)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                sum += userInput;
            }
            Console.WriteLine("Avarage of 50 integers: {0}", sum / 50);
        }
    }
}
