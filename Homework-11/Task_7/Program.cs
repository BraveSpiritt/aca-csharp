namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pointer pointer = new Pointer(15, 35);
            Pointer secondPointer = new Pointer(15, 35);
            Console.WriteLine("Pointers are equals {0} ", pointer == secondPointer);
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
            public static bool operator ==(Pointer left, Pointer right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(Pointer left, Pointer right)
            {
                return !(left == right);
            }
        }
    }
}
