using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrsApiDemo.models {
    [Table("User")]  // a using will be needed: System.ComponentModel.DataAnnotations.Schema
    public class User  // POCO / "model" / "entity"
        {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(30,MinimumLength = 10)]
        public string Password { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(12)]
        public string? Phone { get; set; }

        [StringLength(255)]
        public string? Email { get; set; }

        [Required]
        public bool IsReviewer { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

    }
}
