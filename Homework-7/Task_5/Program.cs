namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rangeArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            for (int i = 0; i < rangeArr.Length; i++)
            {
                if (rangeArr[i] % 2 != 0)
                {
                    Console.Write("{0} ", rangeArr[i]);
                }
            }
        }
    }
}
