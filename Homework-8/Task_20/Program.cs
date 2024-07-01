namespace Task_20
{
    using System;

    [Flags]
    enum PizzaToppings
    {
        None = 0,
        Pepperoni = 1 << 0,    
        Mushroom = 1 << 1,     
        Onion = 1 << 2,        
        Olives = 1 << 3        
    }

    class Program
    {
        static void Main(string[] args)
        {
            PizzaToppings selectedToppings = PizzaToppings.Pepperoni | PizzaToppings.Mushroom;

            Console.WriteLine("Selected Toppings: " + selectedToppings);

            if ((selectedToppings & PizzaToppings.Pepperoni) == PizzaToppings.Pepperoni)
            {
                Console.WriteLine("Pepperoni is selected.");
            }
            if ((selectedToppings & PizzaToppings.Mushroom) == PizzaToppings.Mushroom)
            {
                Console.WriteLine("Mushroom is selected.");
            }
            if ((selectedToppings & PizzaToppings.Onion) == PizzaToppings.Onion)
            {
                Console.WriteLine("Onion is selected.");
            }
            if ((selectedToppings & PizzaToppings.Olives) == PizzaToppings.Olives)
            {
                Console.WriteLine("Olives is selected.");
            }
        }
    }

}
