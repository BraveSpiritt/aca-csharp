namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("When you pass a struct by value, a copy of the entire struct is made and passed to the method or stored in another variable.");
            Console.WriteLine("Value types (including structs) are typically allocated on the stack.");
            Console.WriteLine("When you pass a struct by reference (using ref keyword), you pass a reference to the original struct. No copy is made !");
            Console.WriteLine("Even though structs are value types and typically allocated on the stack, passing by reference allows you to manipulate them as if they were allocated on the heap (where reference types reside).");
        }
    }
}
