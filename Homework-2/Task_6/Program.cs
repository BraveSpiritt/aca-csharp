namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your profession: ");
            string profession = Console.ReadLine();
            Console.Clear();
            Console.Write($"----------------------------\nName: {name}\nSurname: {surname}\nAge: {age}\nProfession: {profession}\n----------------------------");
            Console.ReadKey();
        }
    }
}