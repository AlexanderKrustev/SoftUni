namespace Orders.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public int OrderProductID { get; set; }

        public int Quantity { get; set; }

        public decimal Discount { get; set; }
    }
}
