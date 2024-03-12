using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrsWebNet.Models {
    [Table("User")]
    public class User {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(10)]
        public string Password { get; set; }

        [Required]
        [StringLength(20)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(20)]
        public string Lastname { get; set; }

        [StringLength(12)]
        public string Phone { get; set; }

        [StringLength(75)]
        public string Email { get; set; }

        public Boolean Reviewer { get; set; } = false;

        public Boolean Admin { get; set; } = false;

        public List<Request>? Requests { get; set; }

        /*
         * 
        CREATE TABLE [User] (
	        Id int IDENTITY(1,1),
	        Username varchar(20) NOT NULL UNIQUE,
	        Password varchar(10) NOT NULL,
	        Firstname varchar(20) NOT NULL,
	        Lastname varchar(20) NOT NULL,
	        Phone varchar(12),
	        Email varchar(75),
	        Reviewer bit,
	        Admin bit 
        )
         */


    }
}
