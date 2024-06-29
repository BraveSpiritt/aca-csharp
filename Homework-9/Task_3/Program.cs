namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[3];
            int sum = 0;
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("Enter integer to array: ");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.Write("Elements in the array are: ");
            foreach (int num in intArr)
            {
                sum += num;
                Console.Write(num);
            }
            Console.WriteLine();
            Console.WriteLine("Sum of numbers array: {0}", sum);
        }
    }
}