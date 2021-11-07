using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Milk : Product
    {
        public Milk(string name, double price, double fatRate) : base(name, price)
        {
            this._fatRate = fatRate;

        }
        int volume;
        private double _fatRate;

        public double FatRate
        {
            get { return _fatRate; }
            set { this._fatRate = value; }
        }
    }
}
