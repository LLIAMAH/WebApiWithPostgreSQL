using Microsoft.EntityFrameworkCore;
using WebApiWithPostgreSQL.DB.Configurations;
using WebApiWithPostgreSQL.DB.Entities;

namespace WebApiWithPostgreSQL.DB
{
    public class AppDbCtx(DbContextOptions<AppDbCtx> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsersConfigurations());
        }
    }
}
