namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 4;
            if (age > 30)
            {
                Console.WriteLine("Senior");
            }
            else if (age > 18 && age < 30)
            {
                Console.WriteLine("Adult");
            }
            else if (age > 12 && age < 18)
            {
                Console.WriteLine("Teenager");
            }
            else
            {
                Console.WriteLine("Child");
            }
        }
    }
}