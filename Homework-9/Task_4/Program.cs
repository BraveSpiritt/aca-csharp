namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[4];
            int[] copyArr = new int[4];
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("Enter numbers to copy: ");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 0; i < copyArr.Length; i++)
            {
                copyArr[i] = intArr[i];
            }
            Console.Write("Integers in the first array: ");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Elements copied into the second array: ");
            for (int i = 0; i < copyArr.Length; i++)
            {
                Console.Write(copyArr[i] + " ");
            }



        }
    }
}