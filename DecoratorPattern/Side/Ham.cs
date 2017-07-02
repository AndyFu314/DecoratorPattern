using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Side
{
    public class Ham : CodimentDecorator
    {
        Breakfast breakfast;

        public Ham(Breakfast breakfast)
        {
            this.breakfast = breakfast;
        }

        public override double cost()
        {
            return this.breakfast.cost() + 10;
        }

        public override string GetDescription()
        {
            return this.breakfast.GetDescription() + ", 火腿";
        }
    }
}
