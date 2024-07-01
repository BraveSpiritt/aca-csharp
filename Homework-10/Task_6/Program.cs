namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 48, 2, 3, -99, 154, 58, 66, 99, 10, 25 };
            int result;
            Console.WriteLine("Max number of arr - {0}", FindMaxWithOut(out result, arr));
        }
        public static int FindMaxWithOut(out int result, int[] arr)
        {
            result = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > result)
                {
                    result = arr[i];
                }
            }
            return result;
        }
    }
}
