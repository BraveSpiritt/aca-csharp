namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number:");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            Console.Write("Elements in the array are: ");
            foreach (int num in intArr)
            {
                Console.Write(num);
            }
        }
    }
}