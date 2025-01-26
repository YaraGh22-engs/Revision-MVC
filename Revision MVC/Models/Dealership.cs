namespace Revision_MVC.Models
{
    public class Dealership
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } =string.Empty;

        public ICollection<Car> Cars { get; set; } = new List<Car>();
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }

}
