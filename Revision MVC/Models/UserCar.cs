namespace Revision_MVC.Models
{
    public class UserCar
    {
        public int UserId { get; set; }
        public int CarId { get; set; }

        public User User { get; set; } = default!;
        public Car Car { get; set; } =default!;
    }

}
