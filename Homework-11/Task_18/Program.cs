namespace Task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeoLocation newYorkCity = new GeoLocation(40.7128, -74.0060);
            GeoLocation london = new GeoLocation(51.5074, -0.1278);
            GeoLocation paris = new GeoLocation(48.8566, 2.3522);
            GeoLocation tokyo = new GeoLocation(35.6895, 139.6917);

            Console.WriteLine("Coordinates for Various Cities:");
            Console.WriteLine($"New York City: Latitude={newYorkCity.Latitude}, Longitude={newYorkCity.Longitude}");
            Console.WriteLine($"London: Latitude={london.Latitude}, Longitude={london.Longitude}");
            Console.WriteLine($"Paris: Latitude={paris.Latitude}, Longitude={paris.Longitude}");
            Console.WriteLine($"Tokyo: Latitude={tokyo.Latitude}, Longitude={tokyo.Longitude}");
        }
        struct GeoLocation
        {
            public double Latitude { get; }
            public double Longitude { get; }
            public GeoLocation(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }
        }
    }
}
