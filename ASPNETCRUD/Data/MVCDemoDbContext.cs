using ASPNETCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
