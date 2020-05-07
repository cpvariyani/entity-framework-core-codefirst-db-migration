using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDatabaseFromModel_CodeFirstApproach.DataLayer.ViewModel
{
    public class Developer
    {
        [Column("DeveloperId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DeveloperId { get; set; }

        [Column("DeveloperName")]
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Column("Skills")]
        [Required]
        [StringLength(500)]
        public string Skills { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }
    }
}
