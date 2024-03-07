
using Microsoft.EntityFrameworkCore;

namespace PrsApiDemo.models {
    public class PrsDbContext : DbContext {

        public DbSet<User> Users { get; set; }

        public PrsDbContext(DbContextOptions<PrsDbContext> options) : base(options) {
        }
    }
}
