using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Core.Domain
{
    public class Position 
    {
        [Key]
        [Required]
        public int Id { get; private set; }
        [Required]
        [Column(TypeName = "char(3)")]
        public string Currency { get; private set; }
        [Required]
        [Column(TypeName = "decimal(16 ,2)")]
        public decimal MarketValue { get; private set; }
        [Required]
        public string Name { get; private set; }
        [Required]
        [Column(TypeName = "char(2)")]
        public string Country { get; private set; }

        public virtual Portfolio Portfolio { get; set; }
        public virtual PositionType PositionType { get; set; }


        public Position()
        {

        }
    }
}
