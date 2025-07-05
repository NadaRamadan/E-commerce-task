using e_commerce_system_task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system_task.Models
{
    public class Perishable : Product, Iperishable
    {
        public DateTime ExpiryDate { get; set; }
        public Perishable(string name, decimal price, int quantity, DateTime ExpiryDate) : base(name, price, quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            this.ExpiryDate = ExpiryDate;

        }
    }
}
