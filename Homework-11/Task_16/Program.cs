namespace Task_16
{
    internal class Program
    {
        struct Coordinates
        {
            public double Latitude { get; }
            public double Longitude { get; }

            public Coordinates(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }
            public override string ToString()
            {
                return $"Latitude: {Latitude}, Longitude: {Longitude}";
            }
        }
        static void Main(string[] args)
        {
            Coordinates newYorkCity = new Coordinates(40.7128, -74.0060);
            Coordinates london = new Coordinates(51.5074, -0.1278);

            Console.WriteLine("New York City Coordinates:");
            Console.WriteLine(newYorkCity);

            Console.WriteLine("\nLondon Coordinates:");
            Console.WriteLine(london);
        }
    }
}
