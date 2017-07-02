using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Pizza
    {
        public string Name = "未知";

        public virtual string GetName()
        {
            return Name;
        }

        public abstract double Cost();
    }
}
