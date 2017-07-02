using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Ingredients
{
    public class Beef : IngredientsDecorator
    {
        Pizza pizza;

        public Beef(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public override double Cost()
        {
            return this.pizza.Cost() + 80;
        }

        public override string GetName()
        {
            return this.pizza.GetName() + " +牛肉";
        }
    }
}
