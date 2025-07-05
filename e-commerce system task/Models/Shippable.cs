using e_commerce_system_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace e_commerce_system_task.Models
{
    public class Shippable : Product, Ishippable
    {
        public double Weight { get; set; }
        public Shippable(string name, decimal price, int quantity, double weight) : base(name, price, quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;

        }
       
    }
}
