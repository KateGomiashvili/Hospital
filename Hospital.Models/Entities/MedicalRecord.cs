using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.Entities
{
    public class MedicalRecord
    {
        [Required]
        [MaxLength(15)]
        public string BloodType { get; set; }

        [Required]
        [MaxLength(50)]
        public string Allergies { get; set; }

        [MaxLength(100)]
        public string ChronicDiseases { get; set; }

        [Key]
        [ForeignKey(nameof(Patient))]
        public int Id { get; set; }

    }
}
