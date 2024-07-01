using System.Runtime.InteropServices.ComTypes;

namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It's weekend, let's chill. {0}", Weekdays.Weekend);
        }
        [Flags]
        public enum Weekdays
        {
            None,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Weekend = Sunday | Saturday,
            Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday
        }
    }
}
