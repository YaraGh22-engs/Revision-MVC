namespace Revision_MVC.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceType { get; set; } = string.Empty;
        public DateTime ServiceDate { get; set; }
        public decimal Cost { get; set; }
        public int CarId { get; set; }

        public Car Car { get; set; } = default!;
    }

}
