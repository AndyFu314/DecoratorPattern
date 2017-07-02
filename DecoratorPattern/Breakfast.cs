using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Breakfast
    {
        public string description = "unknow";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
