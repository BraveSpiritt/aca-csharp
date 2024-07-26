using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string[] Toppings { get; set; }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }

        public void Bake()
        {
            Console.WriteLine("Baking at 350 degrees.");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into slices.");
        }

        public void Box()
        {
            Console.WriteLine("Placing the pizza in an official box.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Dough: {Dough}");
            Console.WriteLine($"Sauce: {Sauce}");
            Console.WriteLine($"Toppings: {string.Join(", ", Toppings)}");
        }
    }

}
