namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello", str2 = "hello", str3 = "world";

            bool str1AndStr2 = string.Equals(str1, str2);
            bool str1AndStr3 = string.Equals(str1, str3);

            Console.WriteLine($"Equals() equality - str1 and str2 - {str1AndStr2}\nstr1 and str3 - {str1AndStr3}");
        }
    }
}