namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pointer pointer = new Pointer(15, 35);
            Pointer secondPointer = new Pointer(15, 35);
            Pointer result = pointer + secondPointer;
            Console.WriteLine("NEW points of pointer x: {0}, y: {1} ", result.xPoint, result.yPoint);
        }
        struct Pointer
        {
            public int xPoint { get; }
            public int yPoint { get; }
            public Pointer(int x, int y)
            {
                xPoint = x;
                yPoint = y;
            }
            public static Pointer operator +(Pointer left, Pointer right)
            {
                return new Pointer(left.xPoint + right.xPoint, left.yPoint + right.yPoint);
            }

        }
        
    }
}
