
namespace Pizza_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new ClassicPizzaFactory();
            Pizza pizza = factory.CreatePizza("Margherita");

            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
                Console.WriteLine("Order confirmation:");
                pizza.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Pizza type not available.");
            }
        }
    }
}
