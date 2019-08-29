using System;
using System.Collections.Generic;

namespace WebApplication.Infrastructure.DTO
{
    public class PortfolioDTO
    {
        public string ISINCode { get; set; }
        public DateTime Date { get; set; }
        public string Currency { get; set; }
        public decimal MarketValue { get; set; }
        public IList<PositionDTO> Positions { get; set; }
    }
}
