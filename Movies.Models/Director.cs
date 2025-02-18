using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Director
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string FamilyName { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        public DateTime DoD { get; set; }
        [Required]
        [MaxLength(20)]
        public string Gender { get; set; }

        public string FullName => $"{FirstName} {FamilyName}";
    }
            
}
