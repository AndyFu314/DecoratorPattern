using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.MainCourse
{
    public class Toast : Breakfast
    {
        public Toast()
        {
            base.description = "吐司";
        }

        public override double cost()
        {
            return 10;
        }
    }
}
