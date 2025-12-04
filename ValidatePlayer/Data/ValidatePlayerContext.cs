using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ValidatePlayer.Models;

namespace ValidatePlayer.Data
{
    public class ValidatePlayerContext : DbContext
    {
        public ValidatePlayerContext (DbContextOptions<ValidatePlayerContext> options)
            : base(options)
        {
        }

        public DbSet<ValidatePlayer.Models.Player> Player { get; set; } = default!;
    }
}
