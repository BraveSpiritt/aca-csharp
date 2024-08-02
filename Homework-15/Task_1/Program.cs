namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myZoo = new Zoo();
            myZoo.AddAnimal("Juilbert", "Fox");
            myZoo.AddAnimal("Torosa", "Newt");
            myZoo.AddAnimal("Dumbledore", "Elephant");

            Console.WriteLine("Welcome to the Zoo!");
            foreach (var animal in myZoo)
            {
                Animal currentAnimal = animal;
                Console.WriteLine($"Here is {currentAnimal.Nickname}: {currentAnimal.Name}");
            }
        }
    }
}
