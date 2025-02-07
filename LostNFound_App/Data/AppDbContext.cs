using LostNFound_App.Entities;
using Microsoft.EntityFrameworkCore;

namespace LostNFound_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ItemCategory> ItemsCategory { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Item>().HasData(
            //    new Item
            //    {
            //        Id = 1,
            //        Name = "IPhone XR",
            //        Description = "Sunset orange color, with Mina Photocard behind",
            //        Status = "Found",
            //    },
            //    new Item
            //    {
            //        Id = 2,
            //        Name = "Soundcore R50i",
            //        Description = "black true wireless earbuds with stickers on case",
            //        Status = "Lost",
            //    },
            //    new Item
            //    {
            //        Id = 3,
            //        Name = "File case",
            //        Description = "pink file case found in room j402",
            //        Status = "Found",
            //    }
            //);
            //modelBuilder.Entity<User>().HasData(
            //    new User
            //    {
            //        Id = 1,
            //        FirstName = "Danah Janyll",
            //        LastName = "Amoroso",
            //        ContactNo = "09996899940"
            //    },
            //    new User
            //    {
            //        Id = 2,
            //        FirstName = "Juan",
            //        LastName = "Dela Cruz",
            //        ContactNo = "09996999999"
            //    },
            //    new User
            //    {
            //        Id = 3,
            //        FirstName = "Juana",
            //        LastName = "Dimagiba",
            //        ContactNo = "09999999999"
            //    },
            //    new User
            //    {
            //        Id = 4,
            //        FirstName = "Victor",
            //        LastName = "Hesus",
            //        ContactNo = "09999999969"
            //    }
            //);
            //modelBuilder.Entity<ItemCategory>().HasData(
            //    new ItemCategory
            //    {
            //        Id = 1,
            //        Name = "Valuables"
            //    },
            //    new ItemCategory
            //    {
            //        Id = 2,
            //        Name = "Non-Valuables"
            //    },
            //    new ItemCategory
            //    {
            //        Id = 3,
            //        Name = "Perishables"
            //    },
            //    new ItemCategory
            //    {
            //        Id = 4,
            //        Name = "Others"
            //    }
            //);
        }
    }
}
