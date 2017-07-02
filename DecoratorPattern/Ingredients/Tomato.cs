using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Ingredients
{
    public class Tomato : IngredientsDecorator
    {
        Pizza pizza;

        public Tomato(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double Cost()
        {
            return this.pizza.Cost() + 30;
        }

        public override string GetName()
        {
            return this.pizza.GetName() + " +番茄";
        }
    }
}
