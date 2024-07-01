public class Program
{
    public static void Main()
    {
        Console.Write("Enter a string to reverse:");
        string userInput = Console.ReadLine();

        string reversedString = ReverseString(userInput);

        Console.WriteLine("Reversed string: {0}", reversedString);
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }

        return new string(charArray);
    }
}
