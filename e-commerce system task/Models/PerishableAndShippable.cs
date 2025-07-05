using e_commerce_system_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system_task.Models
{
    public class PerishableAndShippable : Product, Ishippable, Iperishable
    {
        public double Weight { get; set; }
        public DateTime ExpiryDate { get; set; }

        public PerishableAndShippable(string name, decimal price, int quantity, DateTime ExpiryDate, double weight) : base(name, price, quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            this.ExpiryDate = ExpiryDate;
            Weight = weight;

        }
     



    }
}
