using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Core.Domain;
using WebApplication.Core.Repositories;
using WebApplication.Infrastructure.Context;

namespace WebApplication.Infrastructure.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly DatabaseContext _dbContext;
        public PositionRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddAsync(Position position)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Position>> BrowseAsync()
            => await Task.FromResult(_dbContext.Positions.AsEnumerable());
        

        public Task DeleteAsync(Position position)
        {
            throw new NotImplementedException();
        }

        public Task<Position> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Position> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Position position)
        {
            throw new NotImplementedException();
        }
    }
}
