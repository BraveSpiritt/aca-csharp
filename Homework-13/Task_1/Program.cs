namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            Shape circle = new Circle(5.0);
            Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");

            Shape rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea()}");
        }

        public abstract class Shape
        {
            public abstract double CalculateArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double CalculateArea()
            {
                return Width * Height;
            }
        }
    }
}
