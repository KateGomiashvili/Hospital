using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models.Entities
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [EmailAddress]
        public string Email { get; set; }
        public List<Appointment> Appointments { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}
