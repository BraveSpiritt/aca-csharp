using System.Net;

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FileUploading(4) ? "You can upload your file" : "You can't upload file");
        }
        public enum FileExtensions
        {
            txt,
            pdf,
            doc,
            jpg,
            jpeg
        }
        public static bool FileUploading(int fileExtension)
        {
             switch(fileExtension)
            {
                case (int)FileExtensions.txt:
                case (int)FileExtensions.pdf:
                case (int)FileExtensions.doc:
                case (int)FileExtensions.jpg:
                case (int)FileExtensions.jpeg:
                    return true;
                default: 
                    return false;
            }
        }
    }
}
