namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String
            int year = 2024;
            int month = 12;
            int day = year / month;
            Console.WriteLine(day);
            Console.WriteLine($"Integer - whole number: {myNum},\nFloating point number: {myDoubleNum},\nCharacter: {myLetter},\nBoolean: {myBool},\nString: {myText}");

            Console.ReadKey();
        }
    }
}