using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Types
{
    public class HawaiiPizza : Pizza
    {
        public HawaiiPizza()
        {
            base.Name = "夏威夷披薩";
        }

        public override double Cost()
        {
            return 650;
        }
    }
}
