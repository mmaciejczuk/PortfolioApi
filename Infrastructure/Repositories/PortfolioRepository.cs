using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Core.Domain;
using WebApplication.Core.Repositories;
using WebApplication.Infrastructure.Context;

namespace WebApplication.Infrastructure.Repositories
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly DatabaseContext _dbContext;

        public PortfolioRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Portfolio> GetAsync(string isin, DateTime date)
            => await Task.FromResult(_dbContext.Portfolios.SingleOrDefault(x => x.ISINCode == isin && x.Date == date));


        public async Task<IEnumerable<Portfolio>> BrowseAsync()
        {
            var portfolios = _dbContext.Portfolios.AsEnumerable();
            //if (!string.IsNullOrWhiteSpace(isin))
            //{
            //    portfolios = portfolios.Where(x => x.ISINCode.ToLowerInvariant()
            //        .Contains(isin.ToLowerInvariant()));
            //}

            return await Task.FromResult(portfolios);
        }

        public async Task AddAsync(Portfolio portfolio)
        {
            _dbContext.Portfolios.Add(@portfolio);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Portfolio portfolio)
            => await Task.CompletedTask;


        public async Task DeleteAsync(Portfolio portfolio)
        {
            _dbContext.Portfolios.Remove(@portfolio);
            await Task.CompletedTask;
        }

    }
}
