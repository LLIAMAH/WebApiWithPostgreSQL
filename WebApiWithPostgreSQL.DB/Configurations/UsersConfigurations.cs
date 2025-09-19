using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiWithPostgreSQL.DB.Entities;

namespace WebApiWithPostgreSQL.DB.Configurations
{
    internal class UsersConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData([
                new() { Id = 1, Name = "Vasiliy", Email = "vasiliy@email.com" },
                new() { Id = 2, Name = "Vitaliy", Email = "vitaliy@email.com" },
                new() { Id = 3, Name = "Valeriy", Email = "valeriy@email.com" },
                new() { Id = 4, Name = "Oleg", Email = "oleg@email.com" },
                new() { Id = 5, Name = "Ekaterina", Email = "ekaterina@email.com" },
                new() { Id = 6, Name = "Maya", Email = "maya@email.com" }
            ]);
        }
    }
}
