namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{2} has {0} permission - {1}", Permissions.Update.ToString(), CheckingPermissions(Permissions.Director), Permissions.Director);
        }
        [Flags]

        public enum Permissions
        {
            None = 0,
            Write = 1 << 0, 
            Read = 1 << 1, 
            Update = 1 << 2, 
            Delete = 1 << 3, 
            User = None,
            Admin = Write,
            Manager = Write | Update, 
            Director = Read | Update | Delete 
        }

        static public bool CheckingPermissions(Permissions user)
        {
            return user.HasFlag(Permissions.Update);
        }

    }
}
