namespace Task_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 9; 
            BinaryRep binaryEnum = (BinaryRep)intValue; 

            Console.WriteLine("Integer value: " + intValue);
            Console.WriteLine("Enum value: " + binaryEnum);
            Console.WriteLine("Binary representation: " + ConvertToBinaryString(intValue, 8));
        }

        static string ConvertToBinaryString(int value, int bits)
        {
            return Convert.ToString(value, 2).PadLeft(bits, '0');
        }

        [Flags]
        enum BinaryRep
        {
            None = 0,
            FirstElem = 1 << 0,    
            SecondElem = 1 << 1,  
            ThirdElem = 1 << 2,   
            FourthElem = 1 << 3,   
            FifthElem = 1 << 4     
        }
    }
}
