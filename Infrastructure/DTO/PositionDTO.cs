using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication.Infrastructure.DTO
{
    public class PositionDTO
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public decimal MarketValue { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public decimal StorePercentage { get; set; }
    }
}
