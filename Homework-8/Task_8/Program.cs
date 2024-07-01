namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 1; i++)
            {
                Console.WriteLine("Traffic light - {0}, stop", TrafficLight.Red);
                Thread.Sleep(1000);
                Console.WriteLine("Traffic light - {0}, get ready", TrafficLight.Yellow);
                Thread.Sleep(1000);
                Console.WriteLine("Traffic light - {0}, here you go.", TrafficLight.Green);
            }
        }
        public enum TrafficLight
        {
            Red,
            Yellow,
            Green
        }
    }
}
