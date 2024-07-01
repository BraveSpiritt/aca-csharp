namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number from 1 to 4 to get random language:");
            int weatherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Language you choose is {0}", GetLanguages(weatherId));
        }
        enum Languages
        {
            English,
            Espanol,
            Portugese,
            Italiano
        }
        static public string GetLanguages(int weatherId)
        {
            switch (weatherId)
            {
                case (int)Languages.English:
                    return "English";
                case (int)Languages.Espanol:
                    return "Espanol";
                case (int)Languages.Portugese:
                    return "Portugese";
                case (int)Languages.Italiano:
                    return "Italiano";
                default:
                    return "Unkown language";
            }
        }
    }
}
