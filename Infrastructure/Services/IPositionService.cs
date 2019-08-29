using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Infrastructure.DTO;

namespace WebApplication.Infrastructure.Services
{
    public interface IPositionService
    {
        Task<PositionDTO> GetAsync(Guid id);
        Task<PositionDTO> GetAsync(string name);
        Task<IEnumerable<PositionDTO>> BrowseAsync(string name = null);
        Task CreateAsync(string name, string description);
        Task UpdateAsync(Guid id, string name, string description);
        Task DeleteAsync(Guid id);
    }
}
