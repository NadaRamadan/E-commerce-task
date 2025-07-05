using e_commerce_system_task.Interfaces;
using e_commerce_system_task.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system_task.Models
{
    public class Cart
    {
        public List<CartItem> items { get; set; } =new List<CartItem>();
        public Customer customer { get; set; }
        public Cart(Customer customer)

        {
            this.customer = customer;
        }
        public void AddToCart(Product product, int quantity)
        {
            if (quantity > product.Quantity)
            {
                throw new InvalidOperationException($" We can't add {quantity}x  {product.Name}.  only {product.Quantity} in stock.");
            }
            if (quantity == 0)
            {
                throw new InvalidOperationException($" {product.Name} is out of stock.");

            }
            items.Add(new CartItem(product, quantity));
            Console.WriteLine($"{quantity}x {product.Name} added to cart successfully.");



        }



        }





    }

