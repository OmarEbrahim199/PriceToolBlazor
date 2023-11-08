using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PricetoolAPI.Domain.Entities
{
    public class Subsidiary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        public int Cvr { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        // Foreign key to Corporate
        [ForeignKey("Corporate")]
        public int ParentCorporateCvr { get; set; }

        // Navigation property
        public Corporate Corporate { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
