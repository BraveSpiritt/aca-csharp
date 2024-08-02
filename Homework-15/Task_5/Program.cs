namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var centralPark = new Attraction("Central Park", "A large public park in New York City", "Park");
            var metropolitanMuseum = new Attraction("Metropolitan Museum of Art", "One of the world's largest art museums", "Museum");
            var timesSquare = new Attraction("Times Square", "A major commercial intersection and tourist destination", "Landmark");

            var initialAttractions = new List<Attraction> { centralPark, metropolitanMuseum, timesSquare };
            var cityAttractions = new CityAttractions(initialAttractions);
            cityAttractions.AddAttraction(centralPark);
            cityAttractions.AddAttraction(metropolitanMuseum);
            cityAttractions.AddAttraction(timesSquare);
            foreach (var attraction in cityAttractions)
            {
                Console.WriteLine(attraction.Name + ": " + attraction.Description);
            }
        }
    }
}
