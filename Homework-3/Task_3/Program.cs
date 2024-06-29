namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "112309";
            int myInt = Convert.ToInt32(myString);

            Console.WriteLine($"String: {myString}, type of - {myString.GetType().Name},\nInteger converted from string: {myInt}, type of - {myInt.GetType().Name}");
        }
    }
}