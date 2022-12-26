using Zadaca_BlafSoft_Jasin_Shabani.Interfaces;
using Zadaca_BlafSoft_Jasin_Shabani.Models;

namespace Zadaca_BlafSoft_Jasin_Shabani.Services
{
    public class ZadacaService : IZadacaService
    {
        public async Task<Customer> CreateInstances()
        {
            Customer existingCustomer = new Customer
            {
                ID = Guid.NewGuid(),
                Name = "John Smith",
                Orders = new List<Order>()
            };

            // Create a new Order instance and populate it with data
            Order existingOrder = new Order
            {
                ID = Guid.NewGuid(),
                OrderDate = DateTime.Now,
                OrderNumber = "123456",
                OrderItems = new List<OrderItem>()
            };

            // Create a new OrderItem instance and populate it with data
            OrderItem existingOrderItem = new OrderItem
            {
                ID = Guid.NewGuid(),
                Description = "Product A",
                Amount = 10.99m,
                Quantity = 1
            };
            // Add the OrderItem to the Order's OrderItems list
            existingOrder.OrderItems.Add(existingOrderItem);

            // Add the Order to the Customer's Orders list
            existingCustomer.Orders.Add(existingOrder);
            return existingCustomer;
        }
        public async Task<AllCustomers> CustomerPrint()
        {
            Customer existingCustomer = await CreateInstances();

            // Use the DeepCopy method to create a new Customer instance
            Customer newCustomer = existingCustomer.DeepCopy();

            var customers = new AllCustomers();
            customers.NewCustomer = newCustomer;
            customers.OldCustomer = existingCustomer;

            return customers;
        }
    }
}
