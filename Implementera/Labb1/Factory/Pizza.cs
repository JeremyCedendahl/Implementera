using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Factory
{
    public class Pizza : IFood
    {
        public string GetFood()
        {
            return "Crispy Pizza";
        }
    }
}
