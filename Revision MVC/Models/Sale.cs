namespace Revision_MVC.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; } = default!;
        public int UserId { get; set; }
        public User User { get; set; } = default!;
        public int DealershipId { get; set; }
        public Dealership Dealership { get; set; } = default!;
        public DateTime SaleDate { get; set; }
        public decimal SalePrice { get; set; }

        
        
        
    }

}
