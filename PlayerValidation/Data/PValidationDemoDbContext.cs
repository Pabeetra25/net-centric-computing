using Microsoft.EntityFrameworkCore;

namespace PlayerValidation.Data
{
    public class PValidationDemoDbContext : DbContext
    {
        public PValidationDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
    }
}
