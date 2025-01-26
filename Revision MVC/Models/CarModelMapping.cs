namespace Revision_MVC.Models
{
    public static class CarModelMapping
    {
        public static readonly Dictionary<Make, List<string>> ModelsByMake = new Dictionary<Make, List<string>>
    {
        { Make.Toyota, new List<string> { "Corolla", "Camry", "Prius", "RAV4" } },
        { Make.Ford, new List<string> { "Mustang", "F150", "Explorer", "Focus" } },
        { Make.Honda, new List<string> { "Civic", "Accord", "CR-V", "Pilot" } },
        { Make.BMW, new List<string> { "Series 3", "Series 5", "X5", "X3", "i8" } }
        // Add other makes and models as needed
    };
    }

}
