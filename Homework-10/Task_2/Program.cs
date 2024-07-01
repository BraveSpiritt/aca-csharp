using System.Collections;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3, 4, 5 };
            int[] secondArray = { 6, 7, 8, 9, 10};
            Console.WriteLine("Before swap - firstArray");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine("\nBefore swap - secondArray");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }

            SwapValueByRef(ref firstArray, ref secondArray);
        }
        static public void SwapValueByRef(ref int[] firstArray, ref int[] secondArray)
        {
            int[] middleArray = new int[firstArray.Length];
            middleArray = firstArray;
            firstArray = secondArray;
            secondArray = middleArray;
            Console.WriteLine("\nAfter swap - firstArray");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write(firstArray[i] + " ");
            }
            Console.WriteLine("\nAfter swap - secondArray");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ") ;
            }
        }
    }
}
