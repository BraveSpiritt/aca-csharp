using System.Threading.Channels;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first string: ");
            string firstString = Console.ReadLine();
            Console.Write("\nInput second string: ");
            string secondString = Console.ReadLine();
            char[] charArr = firstString.ToCharArray();
            if (CheckingAnargm(charArr, secondString))
            {
                Console.WriteLine("Your inputed strings are anargm");
            }
            else
            {
                Console.WriteLine("Your inputed strings are not anargm");
            }
        }

        static public bool CheckingAnargm(char[] charArr, string str)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                if (str.Contains(charArr[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
