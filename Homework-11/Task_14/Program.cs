namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature(34);
            double fahrenheit = temperature.ToFahrenheit();
            Console.WriteLine("Temperature in Fahrenheit: {0} °F", fahrenheit);

        }
        struct Temperature
        {
            public double Celsius;

            public Temperature(double celsius)
            {
                Celsius = celsius;
            }

            public double ToFahrenheit()
            {
                return Celsius * 9 / 5 + 32;
            }

        }

    }
}
