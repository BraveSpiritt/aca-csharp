namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 8;

            if (grade > 8 && grade < 11)
            {
                Console.WriteLine("Excellent");

            }
            else if (grade > 6 && grade < 9)
            {
                Console.WriteLine("Good");
            }
            else if (grade > 5 && grade < 7)
            {

                Console.WriteLine("Average");
            }
            else if (grade > 3 && grade < 6)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Failed");
            }

        }
    }
}