using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Application.Interfaces.Common;
using Microsoft.EntityFrameworkCore;
using Domain.Entities; // Это чтобы видеть equipment //

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Equipment> Equipments { get; set; }
    }
}
