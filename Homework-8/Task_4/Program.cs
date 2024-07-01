namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cars.RangeRover);
        }
        public enum Cars
        {
            BMW = 320,
            Mercedes = 320,
            Toyota = 250,
            RangeRover = 220,
            Hyundai = 180
        }
    }
}
