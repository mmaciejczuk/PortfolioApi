using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Domain;

namespace WebApplication.Core.Repositories
{
    public interface IPortfolioRepository
    {
        Task<Portfolio> GetAsync(string isin, DateTime date);
        Task<IEnumerable<Portfolio>> BrowseAsync();
        Task AddAsync(Portfolio @potfolio);
        Task UpdateAsync(Portfolio @potfolio);
        Task DeleteAsync(Portfolio @potfolio);
    }
}
