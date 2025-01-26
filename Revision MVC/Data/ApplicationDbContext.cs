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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserCar>()
               .HasKey(uc => new { uc.UserId, uc.CarId });

            modelBuilder.Entity<Car>()
                 .Property(c => c.Make)
                 .HasConversion<string>()
                 .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.FuelType)
                .HasConversion<string>()
                .IsRequired();
        }
    }
}
