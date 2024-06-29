namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "ghelleh";
            bool result = false;
            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                if (palindrome[i] == palindrome[palindrome.Length - i - 1])
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                Console.WriteLine("{0} is palindrome", palindrome);

            }
            else
            {
                Console.WriteLine("{0} is not a palindrome", palindrome);
            }

        }
    }
}