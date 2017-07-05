using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Ingredients
{
    public class Shrimp : IngredientsDecorator
    {
        Pizza pizza;

        public Shrimp(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double Cost()
        {
            return this.pizza.Cost() + 60;
        }

        public override string GetName()
        {
            return this.pizza.GetName() + " +鮮蝦";
        }
    }
}
