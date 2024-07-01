namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = { 1, 2, 3, 4 };
            double avarageValue;
            Console.WriteLine("Avarage value of array - {0}", CalculateAvarageWithOut(out avarageValue, initialArray));
        }
        public static double CalculateAvarageWithOut(out double avarage, int[] initialArray)
        {
            avarage = 0;
            for(int i = 0; i < initialArray.Length; i++)
            {
                avarage += initialArray[i];
                if(i == initialArray.Length - 1)
                {
                    avarage /= initialArray.Length;
                };
            }
            return avarage;
        }
    }
}
