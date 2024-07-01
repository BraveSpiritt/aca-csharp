namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());    
            if(userInput == (int)Weekdays.Saturday |  userInput == (int)Weekdays.Sunday)
            {
                Console.WriteLine("Not working day.");
            }
             else
            {
                Console.WriteLine("It's working day.");
            }
        }
        public enum Weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
