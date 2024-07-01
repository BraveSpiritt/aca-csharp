namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} is currently using system", Role.Client);
        }
        public enum Role
        {
            Admin,
            Director,
            User,
            Client,
            SuperAdmin
        }

    }
}
