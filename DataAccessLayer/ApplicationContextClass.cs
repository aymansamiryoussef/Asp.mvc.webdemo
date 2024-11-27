using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class ApplicationContextClass :IdentityDbContext<ApplicationUser>
    {
        


        public ApplicationContextClass(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Proudct> Proudcts { get; set;}

        public DbSet<Category> categories { get; set;}

        public DbSet<Order> orders { get; set;}

        public DbSet<Orderitem> orderitem { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderID);




            base.OnModelCreating(modelBuilder);
        }





    }
}
