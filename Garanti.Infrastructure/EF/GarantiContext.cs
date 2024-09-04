using Garanti.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garanti.Infrastructure.EF
{
    //GarantiContext classi icerisinde EntityFramework ile ilgili ayarlarin, tablolarin ve veritabaninin olusturuldugu class
    public class GarantiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT;Database=GarantiDB;Trusted_Connection=True;trustServerCertificate=true");
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }


    }
}
