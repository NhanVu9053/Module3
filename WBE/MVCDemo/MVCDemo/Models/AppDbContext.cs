using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                 new Employee()
                 {
                     Id = 1,
                     FullName = "Captain America",
                     Department = Dept.IT,

                     Email = "nhanvu@gmail.com",
                     AvatarPath = "~/images/captian.png"
                 },
                 new Employee()
                 {
                     Id = 2,
                     FullName = "Hulk",
                     Department = Dept.HR,
                     Email = "tramphan@gmail.com",
                     AvatarPath = "~/images/hulk.png"
                 },
                 new Employee()
                 {
                     Id = 3,
                     FullName = "Iron Man",
                     Department = Dept.IT,
                     Email = "nhungnguyen@gmail.com",
                     AvatarPath = "~/images/ironmanchibi.jpg"
                 },
                 new Employee()
                 {
                     Id = 4,
                     FullName = "Spider Man",
                     Department = Dept.HR, 
                     Email = "quanvu@gmail.com",
                     AvatarPath = "~/images/spidermanchibi.jpg"
                 }
                ); 
        }
    }
}
