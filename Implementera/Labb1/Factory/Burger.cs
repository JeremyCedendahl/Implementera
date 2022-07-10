using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Factory
{
    public class Burger : IFood
    {
        public string GetFood()
        {
            return "Juicy Burger";
        }
    }
}
