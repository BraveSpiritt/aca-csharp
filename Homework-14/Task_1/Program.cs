namespace Task_1
{
    internal class Program
    {
        interface IShape
        {
            public int CalculateArea();
        }

        class Rectangle : IShape
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public int CalculateArea()
            {
                return Height * Width;
            }
        }
        class Triangle : IShape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int CalculateArea()
            {
                return Height * Width;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Height = 30; 
            rectangle.Width = 30;
            int areaOfRectangle = rectangle.CalculateArea();
            Console.WriteLine("{0} area of Rectanlge", areaOfRectangle);
            Triangle triangle = new Triangle();
            triangle.Height = 20;
            triangle.Width = 20;
            int areaOfTriangle = triangle.CalculateArea();
            Console.WriteLine("{0} area of Triangle", areaOfTriangle);
        }
    }
}
