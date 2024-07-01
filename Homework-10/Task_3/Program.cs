namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            double[] ints = { 1, 2, 3, 4, 5, 6, 7};
            ModifyArrayWithRef(ref ints);
        }
        public static void ModifyArrayWithRef(ref double[] initialArray)
        {
            for(int i = 0; i < initialArray.Length; i++)
            {
                initialArray[i] = Math.Pow(initialArray[i], 2);
            }
            Console.WriteLine("Modified array values: ");
            for (int i = 0;i < initialArray.Length; i++)
            {
                Console.Write(initialArray[i] + " ");
            }
        }
    }
}
