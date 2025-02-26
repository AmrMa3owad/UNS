using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Orion.Domain.Models;

namespace Orion.Context
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSets for your entities
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Booth> Booths { get; set; }
        public DbSet<BoothOrder> BoothOrders { get; set; }
        public DbSet<Craft> Crafts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAdvertisement> CustomerAdvertisements { get; set; }
        public DbSet<CustomerProduct> CustomerProducts { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryOrder> DeliveryOrders { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Freelancer> Freelancers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialVendor> MaterialVendors { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<OfficeWorker> OfficeWorkers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Orphanage> Orphanages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PreCommunity> PreCommunities { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<SponsorAdvertisement> SponsorAdvertisements { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Website> Websites { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Admin>()
               .HasOne(a => a.Device)
               .WithOne(d => d.Admin)
               .HasForeignKey<Device>(d => d.AdminId);

            builder.Entity<Admin>()
              .HasOne(a => a.Website)
              .WithOne(d => d.Admin)
              .HasForeignKey<Admin>(d => d.WebsiteId);

            builder.Entity<Booth>()
             .HasOne(a => a.Event)
             .WithOne(d => d.Booth)
             .HasForeignKey<Booth>(d => d.EventId);

            builder.Entity<Customer>()
             .HasOne(a => a.Donation)
             .WithOne(d => d.Customer)
             .HasForeignKey<Customer>(d => d.DonationId);

            builder.Entity<Customer>()
             .HasOne(a => a.Payment)
             .WithOne(d => d.Customer)
             .HasForeignKey<Customer>(d => d.PaymentId);

            builder.Entity<Device>()
             .HasOne(a => a.OfficeWorker)
             .WithOne(d => d.Device)
             .HasForeignKey<Device>(d => d.OfficeWorkerId);

            builder.Entity<Order>()
             .HasOne(a => a.Customer)
             .WithOne(d => d.Order)
             .HasForeignKey<Order>(d => d.CustomerId);
        }
    }
}
