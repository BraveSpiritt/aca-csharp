using System.Reflection.Emit;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write number from 1 to 4 to get random weather:");
            int weatherId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Todays weather is {0}", GetWeather(weatherId));
        }
        enum Weather
        {
            Sunny,
            Rainy,
            Cloudy,
            Windy
        }
        static public string GetWeather(int weatherId)
        {
            switch (weatherId)
            {
                case (int)Weather.Sunny:
                    return "Sunny";
                case (int)Weather.Rainy:
                    return "Rainy";
                case (int)Weather.Windy:
                    return "Windy";
                case (int)Weather.Cloudy:
                    return "cloudy";
                default:
                    return "Unkown weather";
            }
        }
    }
}
