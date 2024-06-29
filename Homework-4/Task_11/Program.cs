namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str1 = "TTT";
            string str2 = "TTT";
            string str3 = new string('T', 3);

            bool str1AndStr2 = string.ReferenceEquals(str1, str2);
            bool str1AndStr3 = string.ReferenceEquals(str1, str3);

            Console.WriteLine($"Reference equality - str1 and str2 - {str1AndStr2}\nstr1 and str3 - {str1AndStr3}");
        }

    }
}