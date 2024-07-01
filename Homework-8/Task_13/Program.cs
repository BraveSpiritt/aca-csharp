using System;

namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRoles roles = UserRoles.Admin | UserRoles.Moderator;

            Console.WriteLine("Combined roles {0}", roles);
        }
        [Flags]
        public enum UserRoles
        {
            None = 0,          
            User = 1 << 0,       
            Moderator = 1 << 1,  
            Admin = 1 << 2      
        }
    }
}




