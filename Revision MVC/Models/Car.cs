using Microsoft.VisualBasic.FileIO; 

namespace Revision_MVC.Models
{
    public class Car
    {
        public int Id { get; set; }

        public Make Make { get; set; }
        // Use a dynamic type or object to hold the model
        public string ModelName { get; set; } = string.Empty; // Model name as string

        public int Year { get; set; }
        public string Color { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;

        public int Mileage { get; set; }
        public FuelType FuelType { get; set; }
        public int Horsepower { get; set; }
        public string Image { get; set; } = string.Empty;
        public int DealershipId { get; set; }
        public Dealership Dealership { get; set; } = default!;
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
        public ICollection<UserCar> UserCars { get; set; } = new List<UserCar>();
        public ICollection<Service> Services { get; set; } // Added this navigation property

        //for dropdown list
        //public List<SelectListItem> Makes { get; set; } 
        //public List<SelectListItem> Models { get; set; }


    }

    public enum Make
    {
        Toyota,
        Ford,
        Chevrolet,
        Honda,
        BMW,
        // Add other makes as needed
    }
    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid,
        Hydrogen,
        // Add other fuel types as needed
    }
  








}
