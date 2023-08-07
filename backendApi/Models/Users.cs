using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backendApi.Models
{

    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string username { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string password { get; set; }
    }

}