namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleArr = { -961.54, -3.54, 6.9, -105.32, 48.51, 5978, 66.47 };
            double minimumValue;
            Console.WriteLine("Minimum value of array is {0}.", FindMinimumWithOut(doubleArr, out minimumValue));
        }
        static public double FindMinimumWithOut(double[] doubleArray, out double minimumValue)
        {
            minimumValue = doubleArray[0];
            for(int i = 1; i < doubleArray.Length; i++)
            {
                if (doubleArray[i] < minimumValue)
                {
                     minimumValue = doubleArray[i];
                }
            }
            return minimumValue;
        }

    }
}
