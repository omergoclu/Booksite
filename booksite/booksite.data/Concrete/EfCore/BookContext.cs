using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using booksite.data.Configurations;
using booksite.entity;
using Microsoft.EntityFrameworkCore;

namespace booksite.data.Concrete.EfCore
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Book> Books{get;set;}
        public DbSet<Category> Categories{get;set;}
        public DbSet<Author> Authors{get;set;}
        public DbSet<Publisher> Publishers{get;set;}
        public DbSet<Cart> Carts{get;set;}
        public DbSet<Order> Orders{get;set;}
        public DbSet<CartItem> CartItems{get;set;}
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite("Data Source=BookDb");
        // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new PublisherConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new BookCategoryConfiguration());
            
            modelBuilder.Seed();
        }
        
    }
}