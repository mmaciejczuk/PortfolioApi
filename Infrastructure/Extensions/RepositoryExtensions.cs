using System;
using System.Threading.Tasks;
using WebApplication.Core.Domain;
using WebApplication.Core.Repositories;

namespace WebApplication.Infrastructure.Extensions
{
    public static class RepositoryExtenstions
    {
        public static async Task<Portfolio> GetOrFailAsync(this IPortfolioRepository repository, string isin, DateTime date)
        {
            var @portfolio = await repository.GetAsync(isin, date);
            if (@portfolio == null)
            {
                throw new Exception($"Portfolio with ISIN : '{isin}' does not exist.");
            }

            return @portfolio;
        }
    }
}
