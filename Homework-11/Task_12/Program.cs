namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Each field of a struct itself follows these rules recursively unless explicitly initialized.");
            Console.WriteLine("Numeric Types:\nNumeric types (e.g., int, double, float, decimal) default to 0.\nBoolean Type:\nbool defaults to false.\nCharacter Type:\nchar defaults to 0 (ASCII value 0).\nEnum Types:\nEnum types default to the first enumerator value (typically 0).\nReference Types (including strings):\nReference types default to null.");
        }
    }
}
