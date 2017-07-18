using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities
{
    [Table("UsersASP")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }
        
        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(10)]
        public string Password { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public int  ProfileId { get; set; }

        [Required]
        public DateTime RegisterDate { get; set; }

    }
}
