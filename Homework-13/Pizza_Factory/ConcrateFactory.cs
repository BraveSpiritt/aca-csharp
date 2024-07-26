using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory
{
    public class ClassicPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            return type switch
            {
                "Margherita" => new Margherita(),
                "Pepperoni" => new Pepperoni(),
            };
        }
    }
    public class GourmetPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            return null;
        }
    }
    public class SpicyPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            return null;
        }
    }
    public class CustomPizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            return null;
        }
    }
}
