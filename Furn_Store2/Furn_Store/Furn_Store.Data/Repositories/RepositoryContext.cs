using Furn_Store.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Furn_Store.Data.Data.EFCore
{
    public partial class RepositoryContext : IdentityDbContext<MyUser, MyRole, int>
    {

        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Charachteristics_Item> Charachteristics_Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Items> Order_Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<Factory>()
                .HasMany(c => c.Items)
                .WithOne(e => e.Factory);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Items)
                .WithOne(e => e.Category);
            modelBuilder.Entity<Item>()
                .HasMany(c => c.Order_Items)
                .WithOne(e => e.Item);
            modelBuilder.Entity<Item>()
                .HasOne(a => a.Charachteristics_Item)
                .WithOne(b => b.Item)
                .HasForeignKey<Charachteristics_Item>(b => b.Id);
            modelBuilder.Entity<Order>()
                .HasMany(c => c.Order_Items)
                .WithOne(e => e.Order);
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Orders)
                .WithOne(e => e.Client);*/

            base.OnModelCreating(modelBuilder);
        }

    }
}
