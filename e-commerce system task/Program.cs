using e_commerce_system_task.Services;

namespace e_commerce_system_task.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creating products
            var cheese = new PerishableAndShippable(
               name: "Cheddar",
               price: 70,
               quantity: 5,
               ExpiryDate: DateTime.Now.AddDays(10),
               weight: 0.5
                );
            var TV = new Shippable(
                name: "Samsung",
                price: 10,
                quantity: 10,
                weight: 120
                );
            var MobileScratch = new Product(
                name: "MobileScratch",
                price: 25,
                quantity: 25

                );

            //customers&Carts
            var customer = new Customer("Nada", 2000);
            customer.Cart.AddToCart(cheese, 2);
            customer.Cart.AddToCart(TV, 2);
            customer.Cart.AddToCart(MobileScratch, 2);

            CheckoutService.Checkout(customer.Cart);



            //not enough balance
            var customer2 = new Customer("Amira", 0);


            customer2.Cart.AddToCart(cheese, 1);

            CheckoutService.Checkout(customer2.Cart);

            //no enough quantinty
            var customer3 = new Customer("Omar", 100);
            customer3.Cart.AddToCart(TV, 30);
            CheckoutService.Checkout(customer3.Cart);

            //empty cart


            var customer4 = new Customer("Ahmed", 100);
            CheckoutService.Checkout(customer4.Cart);





        }
    }
    }

      
