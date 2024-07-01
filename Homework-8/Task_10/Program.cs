using System.Linq.Expressions;
using System.Threading.Channels;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to our pizza shop\nHere is our menu:\n Pepperoni pizza - 1\n Onion pizza - 2\n Mushroom pizza - 3\nPlease choose which pizza you want!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} pizza is getting ready!", MakePizza(userInput)); 


        }
        public enum PizzaOrder
        {
            Pepperoni,
            Onion,
            Mushroom,
        }
        public static PizzaOrder MakePizza(int pizzaType)
        {

            switch (pizzaType - 1)
            {
                case (int)PizzaOrder.Pepperoni:
                    return PizzaOrder.Pepperoni;
                case (int)PizzaOrder.Onion:
                    return PizzaOrder.Onion;
                case (int)PizzaOrder.Mushroom:
                    return PizzaOrder.Mushroom;
                default:
                    return 0;
            }
        }
    }
}
