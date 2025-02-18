using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Movies.Models
{
    public class Film
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        
        [ForeignKey(nameof(Director))]
        public int DirectorId { get; set; }

        [ForeignKey(nameof(Studios))]
        public int StudioId { get; set; }

        public string Review { get; set; }
        [ForeignKey(nameof(Countrys))]
        public int CountryId { get; set; }
        [ForeignKey(nameof(Languages))]
        public int LanguageId { get; set; }

        [ForeignKey(nameof(Genres))]
        public int GenreId { get; set; }

        
        public int RunTimeMinutes { get; set; }
        [ForeignKey(nameof(Certificates))]
        public int CertificateID {  get; set; }

        public decimal BudgetDollars { get; set; }

        public decimal BoxOfficeDollars { get; set; }
        public byte OscarNominations { get; set; }
        public byte OscarWins { get; set; }
    }
}
