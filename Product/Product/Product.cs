using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    class Product
    {
        private string _name;
        private double _price;
        private int _count = 0;
        private double _totalIncome = 0;

        public string Name
        {
            get { return _name; }
            set { this._name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { this._price = value; }
        }
        public int Count
        {
            get { return _count; }
            set { this._count = value; }
        }
        public double TotalIncome
        {
            get { return _totalIncome; }
            set { this._totalIncome = value; }
        }

        public Product(string name)
        {
            this._name = name;
        }

        public Product(string name, double price)
        {
            this._name = name;
            this._price = price;
        }
        public bool sell()
        {
            if (_count == 0)
            {
                Console.WriteLine("Cannot be sold!");
                return false;
            }
            _count--;
            Console.WriteLine("Sold!");
            _totalIncome += _price;
            return true;
        }


    }
}
