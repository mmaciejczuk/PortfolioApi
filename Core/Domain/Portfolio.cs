using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace WebApplication.Core.Domain
{
    public class Portfolio
    {
        [Key, Column(Order = 0)]
        [Required]
        [MaxLength(12)]
        public string ISINCode { get; private set; }
        [Key, Column(Order = 1)]
        [Required]
        public DateTime Date { get; private set; }
        [Required]
        [Column(TypeName = "char(3)")]
        public string Currency { get; private set; }
        public virtual ICollection<Position> Positions { get; private set; }

        public Portfolio()
        {

        }

        public Portfolio(string isinCode)
        {
            ISINCode = isinCode;
            Date = DateTime.UtcNow;
        }
    }
}
