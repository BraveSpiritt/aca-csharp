namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentMonth = Convert.ToInt32(DateTime.Now.Month.ToString());
            if (currentMonth > 2 && currentMonth < 6)
            {
                Console.WriteLine("Season is {0}", Seasons.Spring);
            }
            else if (currentMonth > 5 && currentMonth < 9)
            {
                Console.WriteLine("Season is {0}", Seasons.Summer);
            }
            else if (currentMonth > 8 && currentMonth < 11)
            {
                Console.WriteLine("Season is {0}", Seasons.Autumn);
            }
            else
            {
                Console.WriteLine("Season is {0}", Seasons.Winter);

            }
            Console.ReadLine();

        }
        public enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
    }
}
