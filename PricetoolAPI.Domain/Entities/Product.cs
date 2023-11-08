using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PricetoolAPI.Domain.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }
        [Column(TypeName = "decimal(18, 10)")]
        public decimal Principal { get; set; }

        // Foreign key to Subsidiary
        [ForeignKey("Subsidiary")]
        public int SubsidiaryCvr { get; set; }

        // Navigation property
        public Subsidiary Subsidiary { get; set; }
    }
}
