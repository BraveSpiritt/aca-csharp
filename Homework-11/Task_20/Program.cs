namespace Task_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point startPoint = new Point(1, 1);
            Point endPoint = new Point(4, 5);
            LineSegment segment = new LineSegment(startPoint, endPoint);

            Console.WriteLine($"Line Segment from ({segment.Start.X}, {segment.Start.Y}) to ({segment.End.X}, {segment.End.Y})");
        }
        struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        struct LineSegment
        {
            public Point Start { get; }
            public Point End { get; }

            public LineSegment(Point start, Point end)
            {
                Start = start;
                End = end;
            }
        }
    }
}
