using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace assignment2.Models
{
    public class DataModel
    {
        [Column(TypeName="varchar(20)")]
        [Key]
        public string Email { get; set; }
        [Column(TypeName = "varchar(20)")]
        public int Password { get; set; }
    }

  
}
