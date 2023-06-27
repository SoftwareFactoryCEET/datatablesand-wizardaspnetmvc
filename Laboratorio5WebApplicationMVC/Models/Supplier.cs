namespace Laboratorio5WebApplicationMVC.Models
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
