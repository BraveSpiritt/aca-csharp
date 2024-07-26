using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory
{
        public class Margherita : Pizza
        {
            public Margherita()
            {
                Name = "Margherita Pizza";
                Dough = "Thin crust";
                Sauce = "Tomato sauce";
                Toppings = new string[] { "Fresh Mozzarella", "Basil", "Tomatoes" };
            }
        }
        public class Pepperoni : Pizza
        {
            public Pepperoni()
            {
                Name = "Pepperoni Pizza";
                Dough = "Regular crust";
                Sauce = "Tomato sauce";
                Toppings = new string[] { "Mozzarella", "Pepperoni" };
            }
        }
}
