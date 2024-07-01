namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write style you want to use!: ");
            string userStyle = Console.ReadLine();
            if(userStyle.ToLower().Contains(Flags.Bold.ToString().ToLower()) & userStyle.ToLower().Contains(Flags.Italic.ToString().ToLower()))
            {
                Console.WriteLine("Your style contains {0} and {1}.", Flags.Bold, Flags.Italic);
            } else if (userStyle.ToLower().Contains(Flags.Underline.ToString().ToLower()) & userStyle.ToLower().Contains(Flags.Italic.ToString().ToLower()))
            {
                Console.WriteLine("Your style contains {0} and {1}.", Flags.Underline, Flags.Italic);
            } else
            {
                Console.WriteLine("Your style contains {0} of them.", Flags.None);
            }
        }
        [Flags]

        public enum Flags
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 3
        }
    }
}
