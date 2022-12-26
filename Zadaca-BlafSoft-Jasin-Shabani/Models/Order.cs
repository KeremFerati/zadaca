namespace Zadaca_BlafSoft_Jasin_Shabani.Models
{
    public class Order
    {
        public Guid ID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order DeepCopy()
        {
            Order orderCopy = new Order
            {
                ID = Guid.NewGuid(),
                OrderDate = this.OrderDate,
                OrderNumber = this.OrderNumber,
                OrderItems = new List<OrderItem>()
            };

            foreach (OrderItem orderItem in this.OrderItems)
            {
                orderCopy.OrderItems.Add(orderItem.DeepCopy());
            }

            return orderCopy;
        }
        public override string? ToString()
        {
            return $"Order ID:{ID} \n OrderDate:{OrderDate} \n OrderNumber:{OrderNumber}";
        }
    }

}
