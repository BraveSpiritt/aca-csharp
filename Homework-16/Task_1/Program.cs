namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var number in RangeGenerator(5, 10))
            {
                Console.Write(number + " ");
            }
        }
        static IEnumerable<int> RangeGenerator(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return i;
            }
        }
    }
}
