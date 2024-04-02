using System;
using finalPOCService.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace finalPOCService.database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = NL10-DF2605; Initial Catalog = CapstoneEXL; Integrated Security = True; Encrypt = False");
        }
        public DbSet<User> users { get; set; }
        public DbSet<Alumni> alumnis { get; set;}
    }
}