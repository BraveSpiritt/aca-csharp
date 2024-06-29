namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "hello", str2 = "hello", str3 = "world";
            string str1HashCode = string.GetHashCode(str1).ToString();
            string str2HashCode = string.GetHashCode(str2).ToString();
            string str3HashCode = string.GetHashCode(str3).ToString();


            Console.WriteLine($"str1 and str2 has same hashCode - {str1HashCode == str2HashCode},\nstr3 hashCode - {str3HashCode}");

        }
    }
}