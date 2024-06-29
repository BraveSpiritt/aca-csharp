namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[3];
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write("Enter 3 numbers, please repeat one of them.");
                intArr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i] != intArr[i - 1])
                {
                    if (intArr[i] != intArr[intArr.Length - 1] && intArr[i - 1] == intArr[intArr.Length - 1])
                    {
                        Console.WriteLine(" The unique elements found in the array are: " + intArr[i]);
                    }
                    else if (intArr[i - 1] != intArr[intArr.Length - 1] && intArr[i - 1] == intArr[i])
                    {
                        Console.WriteLine(" The unique elements found in the array are: " + intArr[i - 1]);
                    }
                }
                else if (intArr[i] != intArr[intArr.Length - 1])
                {
                    Console.WriteLine(" The unique elements found in the array are: " + intArr[intArr.Length - 1]);
                }
            }
        }
    }
}