
namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 101);
                Console.Write("{0} ", randomNumber);
            }
        }
    }
}
