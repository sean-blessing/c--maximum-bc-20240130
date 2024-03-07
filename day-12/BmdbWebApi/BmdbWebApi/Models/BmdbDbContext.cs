using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace BmdbWebApi.Models {
    public class BmdbDbContext : DbContext {

        public DbSet<Movie> Movies { get; set; }

        // constructor to support dependency injection (via a service)
        public BmdbDbContext(DbContextOptions<BmdbDbContext> options) : base(options) {
            }
    }
}
