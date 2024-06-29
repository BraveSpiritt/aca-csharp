namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fibSeqNum = 45;
            int prev = 0;
            int current = 1;
            Console.Write(prev + " ");

            for (int i = 0; i < fibSeqNum; i++)
            {
                Console.Write(current + " ");
                int next = prev + current;
                prev = current;
                current = next;
            }
        }
    }
}