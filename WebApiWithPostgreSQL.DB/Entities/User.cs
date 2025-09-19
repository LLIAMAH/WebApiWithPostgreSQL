using System.ComponentModel.DataAnnotations;

namespace WebApiWithPostgreSQL.DB.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required, MaxLength(256)]
        public string Name { get; set; }
        [Required, MaxLength(512)]
        public string Email { get; set; }
    }
}
