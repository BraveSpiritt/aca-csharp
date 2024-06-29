namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 54, 48, 10, -254 };
            int maxNum = Int32.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxNum) maxNum = arr[i];
            }
            Console.WriteLine($"Max num of array: {maxNum}");
        }
    }
}