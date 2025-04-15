using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Entities; // чтобы видеть Entity, например Equipment

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> // Реализуем IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets
        
        public DbSet<Product> Products { get; set; }

        // Реализуем SaveChangesAsync из IApplicationDbContext
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }

   
}
