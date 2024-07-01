namespace Task_5
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            switch (Weekdays.Sunday)
            {
                case Weekdays.Monday:
                case Weekdays.Tuesday:
                case Weekdays.Wednesday:
                case Weekdays.Thursday:
                case Weekdays.Friday:
                    Console.WriteLine("Working day");
                    break;
                case Weekdays.Saturday:
                case Weekdays.Sunday:
                    Console.WriteLine("Not working day");
                    break;
                default:
                    Console.WriteLine("Unkown day");
                    break;
            }
        }

    }
}
