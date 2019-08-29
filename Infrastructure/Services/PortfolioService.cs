using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Core.Domain;
using WebApplication.Core.Repositories;
using WebApplication.Infrastructure.Context;
using WebApplication.Infrastructure.DTO;
using WebApplication.Infrastructure.Extensions;

namespace WebApplication.Infrastructure.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly DatabaseContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IPortfolioRepository _portfolioRepository;
        private readonly IPositionRepository _positionRepository;

        public PortfolioService(DatabaseContext dbContext, IMapper mapper, IPortfolioRepository portfolioRepository, IPositionRepository positionRepository)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
            _positionRepository = positionRepository;
        }

        public async Task<IEnumerable<PortfolioDTO>> BrowseAsync()
            =>  await Task.FromResult(_dbContext.Portfolios.OrderBy(b => b.ISINCode)
                .Select(b => new PortfolioDTO
                {
                    ISINCode = b.ISINCode,
                    Date = b.Date,
                    Currency = b.Currency,
                    MarketValue = b.MarketValue,
                    Positions = b.Positions.Select(c => new PositionDTO
                                            {
                                                Id = c.Id,
                                                Currency = c.Currency,
                                                MarketValue = c.MarketValue,
                                                Name = c.Name,
                                                Country = c.Country,
                                                StorePercentage = c.MarketValue*100/b.MarketValue})
                                                .OrderBy(c=>c.StorePercentage).ToList()
                }).ToList());        

        public async Task CreateAsync(Portfolio portfolio)
        {
            var @portfolioResult = await _portfolioRepository.GetAsync(portfolio.ISINCode, portfolio.Date);
            if (@portfolioResult != null)
            {
                throw new Exception($"Portfolio ISIN: {portfolio.ISINCode} already exists.");
            }

            await _portfolioRepository.AddAsync(portfolio);
        }

        public async Task DeleteAsync(string isin, DateTime date)
        {
            var @portfolio = await _portfolioRepository.GetOrFailAsync(isin, date);
            await _portfolioRepository.DeleteAsync(@portfolio);
        }

        public async Task<PortfolioDTO> GetAsync(string isin, DateTime date)
        {
            var @portfolio = await _portfolioRepository.GetAsync(isin, date);
            return _mapper.Map<PortfolioDTO>(@portfolio);
        }

        public async Task UpdateAsync(string isin, DateTime date)
        {
            var @portfolio = await _portfolioRepository.GetAsync(isin, date);
            if (@portfolio != null)
            {
                throw new Exception($"Portfolio ISIN: {isin} already exists.");
            }

            @portfolio = await _portfolioRepository.GetOrFailAsync(isin, date);
            //@portfolio.SetName(name);
            //@portfolio.SetDescription(description);
        }
    }
}
