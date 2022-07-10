using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Factory
{
    class PizzaCreator : Creator
    {
        public override IFood FactoryMethod()
        {
            return new Pizza();
        }
    }
}
