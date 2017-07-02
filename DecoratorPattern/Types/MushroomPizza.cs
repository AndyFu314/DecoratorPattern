using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Types
{
    public class MushroomPizza: Pizza
    {
        public MushroomPizza()
        {
            base.Name = "蘑菇披薩";
        }

        public override double Cost()
        {
            return 600;
        }
    }
}
