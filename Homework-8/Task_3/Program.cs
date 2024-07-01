namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter code to get official language: ");
            //Languages languageCode = Console.ReadLine();
            Console.WriteLine("You choose {0}", GetOfficialName(Languages.English));
            Console.WriteLine(typeof (Languages));
        }
        public enum Languages
        {
            English,
            Spanish,
            French,
            Russian,
            Armenian,
            Georgian
        }


        static public string GetOfficialName(Languages lang)
        {
            switch (lang)
            {
                case Languages.English:
                    return "English";
                case Languages.Spanish:
                    return "Español";
                case Languages.French:
                    return "Français";
                default:
                    return "Unknown";
            }

        }
    }
}
