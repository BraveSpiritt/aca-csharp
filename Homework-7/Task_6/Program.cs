namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userNumber = Console.ReadLine();
            double sum = 0;

            for (int i = 0; i < userNumber.Length; i++)
            {
                int convertedNum = userNumber[i] - '0';
                sum += Math.Pow(convertedNum, userNumber.Length);
            }
            if (sum == Convert.ToInt32(userNumber))
            {
                Console.WriteLine("{0} is an armstrong num", userNumber);
            }
            else
            {
                Console.WriteLine("{0} is not an armstrong num", userNumber);
            }
        }
    }
}