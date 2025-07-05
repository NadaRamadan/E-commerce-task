using e_commerce_system_task.Interfaces;
using e_commerce_system_task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system_task.Services
{

    /*I separated checkout logic into a CheckoutService class
     to follow SRP and keep Cart focused on item management.
    This also makes future extensions (like discount handling 
    or payment processing) cleaner*/
    public class CheckoutService
    {
        
            public static void Checkout(Cart cart)
            {
                if (cart.items.Count == 0)
                    throw new InvalidOperationException("Cart is empty.");

                decimal subtotal = 0;
                double totalWeight = 0;
                List<ShippingItem> shippingItems = new();

                foreach (var item in cart.items)
                {
                    var product = item.Product;

                    if (product is Iperishable p && p.ExpiryDate <= DateTime.Now)
                        throw new InvalidOperationException($"{product.Name} is expired.");
                    //checking quantity
                    if (product.Quantity == 0)
                        throw new InvalidOperationException($"{product.Name} is out of stock.");

                    if (product is Ishippable s)
                    {
                        shippingItems.Add(new ShippingItem(product.Name, s.Weight, item.Quantity));
                        totalWeight += s.Weight * item.Quantity;
                    }

                    subtotal += product.Price * item.Quantity;
                product.Quantity -= item.Quantity;

            }

            const decimal shippingRatePerGram = 0.01m;
                decimal shippingFee = (decimal)totalWeight * shippingRatePerGram;
                decimal total = subtotal + shippingFee;

            //checking balance
                if (cart.customer.Balance < total)
                    throw new InvalidOperationException("Insufficient balance.");

                cart.customer.Balance -= total;

                Console.WriteLine("**Checkout receipt**");
            foreach(var item in cart.items)
            {
                Console.WriteLine($"{item.Quantity}x {item.Product.Name,-15} {item.Quantity*item.Product.Price} ");
            }
            Console.WriteLine("-----------------------------");
                Console.WriteLine($"Subtotal:{subtotal,15}");
                Console.WriteLine($"Shipping Fees:{shippingFee,10}");
                Console.WriteLine($"Total Paid:{total,15}");

                ShippingService.ship(shippingItems);
            }
        }

    }

