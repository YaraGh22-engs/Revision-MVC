namespace Revision_MVC.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        public Car Car { get; set; } = default!;
        public User User { get; set; } = default!;
    }

}
