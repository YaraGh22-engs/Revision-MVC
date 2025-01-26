namespace Revision_MVC.Models.VM
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public string ModelName { get; set; }
        public List<SelectListItem> Makes { get; set; }
        public List<SelectListItem> Models { get; set; }
        // Other properties

        public CarViewModel()
        {
            Makes = Enum.GetValues(typeof(Make)).Cast<Make>()
                .Select(m => new SelectListItem { Value = m.ToString(), Text = m.ToString() })
                .ToList();
            Models = new List<SelectListItem>(); // Initially empty
        }
    }

}
