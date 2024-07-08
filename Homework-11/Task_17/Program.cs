namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(8, 16);
            
            Console.WriteLine("Perimetr : {0}\nArea : {1} ", rectangle.CalculatePerimetr(), rectangle.CalculateArea());
        }
        struct Rectangle
        {
            public int width; 
            public int height;
            public Rectangle(int x, int y)
            {
                width = x;
                height = y;
            }
            public int CalculateArea()
            {
                return width * height;
            }
            public int CalculatePerimetr()
            {
                return 2 * width + 2 * height;
            }
        }
    }
}
