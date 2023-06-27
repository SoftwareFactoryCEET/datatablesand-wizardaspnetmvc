namespace Laboratorio5WebApplicationMVC.Models
{
    public class Product
    {

        public Product()
        {
            OrderItems = new List<OrderItem>();
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Package { get; set; }
        public bool IsDiscontinued { get; set; } = false;

        public virtual Supplier Supplier { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
    }
}
