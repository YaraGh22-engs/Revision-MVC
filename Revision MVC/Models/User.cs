namespace Revision_MVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;

        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
        public ICollection<UserCar> UserCars { get; set; }  = new List<UserCar>();
    }

}
