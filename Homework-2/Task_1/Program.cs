namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your year of birth: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int age = 2024 - year;
            Console.Clear();
            Console.WriteLine($"You are {age} years old");
        }
    }
}
