namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numericString = "240599";
            string nonNumericString = "asd23445";
            int resultNonNumeric;

            int parsedValueOfNumeric = int.Parse(numericString);
            bool isParsedFromNonNumericString = int.TryParse(nonNumericString, out resultNonNumeric);


            Console.WriteLine($"Numeric string parsed, result - {parsedValueOfNumeric},\nNon numeric parsed, result - {isParsedFromNonNumericString}");
        }
    }
}
