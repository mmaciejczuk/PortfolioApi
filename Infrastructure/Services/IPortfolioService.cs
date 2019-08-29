using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Domain;
using WebApplication.Infrastructure.DTO;

namespace WebApplication.Infrastructure.Services
{
    public interface IPortfolioService
    {
        Task<PortfolioDTO> GetAsync(string name, DateTime date);
        Task<IEnumerable<PortfolioDTO>> BrowseAsync();
        Task CreateAsync(Portfolio portfolio);
        Task UpdateAsync(string isin, DateTime date);
        Task DeleteAsync(string isin, DateTime date);
    }
}
