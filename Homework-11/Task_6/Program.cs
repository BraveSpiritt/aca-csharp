namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pointer pointer = new Pointer(15, 35);
            Console.WriteLine("Point of x : {0}, y: {1}", pointer.xPoint, pointer.yPoint);
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
        }
    }
}
