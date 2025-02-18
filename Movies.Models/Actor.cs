using System.Reflection;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Movies.Models
{
    public class Actor
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
        [MaxLength(20)]
        public string Gender { get; set; }
        [Required]
        public DateTime DoB {  get; set; }
        [Required]
        public DateTime DoD {  get; set; }

        public string FullName => $"{FirstName} {FamilyName}";

    }
}
