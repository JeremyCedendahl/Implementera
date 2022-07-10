using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Factory
{
    abstract class Creator
    {
        public abstract IFood FactoryMethod();

        public string FoodOperation()
        {
            var food = FactoryMethod();

            var result = food.GetFood();

            return result;
        }
    }
}
