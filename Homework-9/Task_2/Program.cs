namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[3];
            int x = intArr.Length - 1;
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("Enter integer to array: ");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.Write("The values stored in the array are : ");
            foreach (int i in intArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("The values in reverse order are : ");
            while (x >= 0)
            {
                Console.Write(intArr[x] + " ");
                x--;
            }

        }
    }
}