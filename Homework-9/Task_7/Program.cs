
using System;

class MergeSortedArrays
{
    static void Main()
    {
        int[] intArr = new int[3];
        int[] newIntArr = new int[3];
        for (int i = 0; i < intArr.Length; i++)
        {
            Console.Write("Enter number to first arr: ");
            intArr[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter number to second arr: ");
            newIntArr[i] = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        int[] mergedArr = MergeArrays(intArr, newIntArr);
        Console.WriteLine("The merged array in ascending order: " + string.Join(" ", mergedArr));
    }

    static int[] MergeArrays(int[] intArr, int[] newIntArr)
    {
        int n = intArr.Length;
        int[] mergedArr = new int[2 * n];
        int i = 0, j = 0, k = 0;

        while (i < n && j < n)
        {
            if (intArr[i] <= newIntArr[j])
            {
                mergedArr[k++] = intArr[i++];
            }
            else
            {
                mergedArr[k++] = newIntArr[j++];
            }
        }

        while (i < n)
        {
            mergedArr[k++] = intArr[i++];
        }

        while (j < n)
        {
            mergedArr[k++] = newIntArr[j++];
        }

        return mergedArr;
    }
}
