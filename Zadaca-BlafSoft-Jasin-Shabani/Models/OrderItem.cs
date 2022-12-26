namespace Zadaca_BlafSoft_Jasin_Shabani.Models
{
    public class OrderItem
    {
        public Guid ID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }

        public OrderItem DeepCopy()
        {
            return new OrderItem
            {
                ID = Guid.NewGuid(),
                Description = this.Description,
                Amount = this.Amount,
                Quantity = this.Quantity
            };
        }

        public override string? ToString()
        {
            return $"OrderItems ID:{ID} \n Description:{Description} \n Amount:{Amount}\n Quantity:{Quantity}";
        }
    }
}
