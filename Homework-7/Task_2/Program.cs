namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            string userString = Console.ReadLine();
            Console.Write("Enter character:");
            char userChar = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == userChar) count++;
            }
            Console.WriteLine("Character {0} appears {1} time.", userChar, count);
        }
    }
}