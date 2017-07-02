using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Side
{
    public class Cheese : CodimentDecorator
    {
        Breakfast breakfast;

        public Cheese(Breakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public override double cost()
        {
            return this.breakfast.cost() + 5;
        }

        public override string GetDescription()
        {
            return this.breakfast.GetDescription() + ", 起司";
        }
    }
}
