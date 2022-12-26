namespace Zadaca_BlafSoft_Jasin_Shabani.Models
{
    
    public class Customer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer DeepCopy()
        {
            Customer customerCopy = new Customer
            {
                ID = Guid.NewGuid(),
                Name = this.Name,
                Orders = new List<Order>()
            };

            foreach (Order order in this.Orders)
            {
                customerCopy.Orders.Add(order.DeepCopy());
            }

            return customerCopy;
        }

        public override string? ToString()
        {
            return $"Customer ID:{ID} \n Customer Name:{Name}";
        }
    }
}
