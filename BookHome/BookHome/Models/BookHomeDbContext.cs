using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookHome.Models
{
    public class BookHomeDbContext : IdentityDbContext
    {
        public BookHomeDbContext(DbContextOptions<BookHomeDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Database.SetInitializer<demoEntities>(null);
            modelBuilder.Entity<User>().ToTable("Users");
          

            base.OnModelCreating(modelBuilder);
            //modelBuilder.Ignore<User>();


        }

    }
}
