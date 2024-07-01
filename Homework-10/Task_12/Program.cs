namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            CalculateStatistics(numbers, out int sum, out double average, out int max);
            Console.WriteLine("Sum: {0}, Average: {1}, Max: {2}", sum, average, max);
        }
        static void CalculateStatistics(int[] numbers, out int sum, out double average, out int max)
        {
            sum = 0;
            max = int.MinValue;
            foreach (var number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }
            average = (double)sum / numbers.Length;
        }
    }
}
