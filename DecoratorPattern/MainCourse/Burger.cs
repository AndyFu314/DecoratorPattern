using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.MainCourse
{
    public class Burger : Breakfast
    {
        public Burger()
        {
            base.description = "漢堡"; 
        }
        public override double cost()
        {
            return 15;
        }
    }
}
