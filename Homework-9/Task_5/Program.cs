namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[3];
            int count = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("Enter 3 numbers, please repeat one of them.");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i] == intArr[i - 1] || intArr[i] == intArr[intArr.Length - 1])
                {
                    count++;
                    Console.WriteLine("Total number of duplicate elements found in the array is: " + count);
                }
            }
        }
    }
}