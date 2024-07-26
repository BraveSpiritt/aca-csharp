using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Factory
{
        public abstract class PizzaFactory
        {
            public abstract Pizza CreatePizza(string type);
        }
}
