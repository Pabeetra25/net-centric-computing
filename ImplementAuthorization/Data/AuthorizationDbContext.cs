using ImplementAuthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace ImplementAuthorization.Data
{
    public class AuthorizationDbContext : DbContext
    {
        public AuthorizationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SalesLeadEntity> SalesLead { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
