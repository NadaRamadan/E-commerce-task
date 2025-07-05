using e_commerce_system_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system_task.Models
{
    public class ShippingItem : IShippingItem
    {
        private readonly string _name;
        private readonly double _weight;
        private readonly int _quantity;

        public ShippingItem(string name, double weight, int quantity)
        {
            this._name = name;
            this._weight = weight;
            this._quantity = quantity;
        }
        public string GetName() => _name;
        public double GetWeight() => _weight;
        public int GetQuantity() => _quantity;
    }
}
