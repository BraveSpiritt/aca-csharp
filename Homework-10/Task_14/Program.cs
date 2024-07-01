namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input rectangles width and height.");
            Console.Write("\nWidth:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nHeight:");
            int height = Convert.ToInt32(Console.ReadLine());
            var rectanglesInfo = CalculateRectangle(width, height);
            Console.WriteLine("Rectanlges area - {0}, perimetr - {1}", rectanglesInfo.area, rectanglesInfo.perimetr);
        }
        public static (int area, int perimetr) CalculateRectangle(int widht , int height)
        {
            int area = widht * height;
            int perimetr = 2 * widht + 2 * height;
            return (area, perimetr);
        }
    }
}
