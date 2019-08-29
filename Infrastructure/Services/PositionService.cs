using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Infrastructure.DTO;

namespace WebApplication.Infrastructure.Services
{
    public class PositionService : IPositionService
    {
        public Task<IEnumerable<PositionDTO>> BrowseAsync(string name = null)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(string name, string description)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PositionDTO> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PositionDTO> GetAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, string name, string description)
        {
            throw new NotImplementedException();
        }
    }
}
