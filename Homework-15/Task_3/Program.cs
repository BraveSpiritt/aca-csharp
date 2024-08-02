namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stop1 = new Stop("Station 1");
            var stop2 = new Stop("Station 2");
            var stop3 = new Stop("Station 3");
            var trainRoute = new TrainRoute(new List<Stop> { stop1, stop2, stop3 });
            foreach (var stop in trainRoute)
            {
                Console.WriteLine($"Exploring {stop.Name}");
            }
        }
    }
}
