using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Adapter
{
    class Adapterr : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapterr(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }
        public string GetRequest()
        {
            return $"The menu : {this._adaptee.GetMenu()}";
        }
    }
}
