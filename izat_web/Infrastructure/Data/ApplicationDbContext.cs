using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Collections; // чтобы видеть Entity, например Equipment

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> // Реализуем IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets
        
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
       



  
        

    }




}
