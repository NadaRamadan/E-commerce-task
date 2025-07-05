using e_commerce_system_task.Interfaces;
using e_commerce_system_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system_task.Services
{
    public class ShippingService
    {

        public static void ship(List<ShippingItem> shipables)
        {
            double total_weight = 0;
            Console.WriteLine("***Shipment notice***");
            foreach(ShippingItem shippingItem in shipables)
            {
                Console.WriteLine($"{shippingItem.GetQuantity()}x {shippingItem.GetName(),-15} {shippingItem.GetWeight()} g");
                total_weight += shippingItem.GetWeight();
            }
            Console.WriteLine($"Total Package Weight {total_weight/1000} kg");
            
        }
        
    }
}
