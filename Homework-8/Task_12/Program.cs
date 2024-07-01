namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            FilePermissions permissions = FilePermissions.Read | FilePermissions.Write | FilePermissions.Execute;
            Console.WriteLine("Original Permissions: " + permissions);
            permissions = ClearPermission(permissions, FilePermissions.Write);
            Console.WriteLine("Permissions after clearing Write: " + permissions);
            permissions = ClearPermission(permissions, FilePermissions.Execute);
            Console.WriteLine("Permissions after clearing Execute: " + permissions);
        }


        [Flags]
        public enum FilePermissions
        {
            None = 0,
            Read = 1,     
            Write = 2,    
            Execute = 4   
        }
        static FilePermissions ClearPermission(FilePermissions permissions, FilePermissions permissionToClear)
        {
            return permissions & ~permissionToClear;
        }
    }
}
