using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Core.Domain
{
    public class PositionType 
    {
        [Key]
        [Required]
        public int Id { get; private set; }
        [Required]
        public string Name { get; private set; }
        public virtual ICollection<Position> Positions { get; private set; }
    }
}
