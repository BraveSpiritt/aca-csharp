namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intValue = 10;
            double doubleValue = intValue;
            Console.WriteLine($"intValue to doubleValue - {doubleValue}");
            doubleValue = 10.5;
            intValue = (int)doubleValue;
            Console.WriteLine($"doubleValue to intValue - {intValue}");
            intValue = 10;
            string stringValue = intValue.ToString();
            Console.WriteLine($"intValue to stringValue - {stringValue}");
            stringValue = "10";
            intValue = int.Parse(stringValue);
            Console.WriteLine($"stringValue to intValue - {intValue}");
            doubleValue = 10.5;
            stringValue = doubleValue.ToString();
            Console.WriteLine($"doubleValue to stringValue - {stringValue}");
            stringValue = "10.5";
            doubleValue = double.Parse(stringValue);
            Console.WriteLine($"stringValue to doubleValue - {doubleValue}");
            bool boolValue = true;
            stringValue = boolValue.ToString();
            Console.WriteLine($"boolValue to stringValue - {stringValue}");
            stringValue = "true";
            boolValue = bool.Parse(stringValue);
            Console.WriteLine($"stringValue to boolValue - {boolValue}");
            char charValue = 'A';
            intValue = (int)charValue;
            Console.WriteLine($"charValue to intValue - {intValue}");
            intValue = 65;
            charValue = (char)intValue;
            Console.WriteLine($"intValue to charValue - {charValue}");
        }
    }
}