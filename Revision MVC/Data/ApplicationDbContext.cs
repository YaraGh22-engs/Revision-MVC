using Microsoft.EntityFrameworkCore;

namespace Revision_MVC.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Car> cars { get; set; } 
        public DbSet<Dealership> dealerships { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Sale> sales { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserCar> userCars { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCar>().HasKey(e=>new { e.UserId, e.CarId});
            base.OnModelCreating(modelBuilder);
        }
    }
}
