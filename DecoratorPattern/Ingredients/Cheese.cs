using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Ingredients
{
    public class Cheese : IngredientsDecorator
    {
        Pizza pizza;

        public Cheese(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double Cost()
        {
            return this.pizza.Cost() + 50;
        }

        public override string GetName()
        {
            return this.pizza.GetName() + " +起司";
        }
    }
}
