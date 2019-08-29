using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Domain;

namespace WebApplication.Core.Repositories
{
    public interface IPositionRepository
    {
        Task<Position> GetAsync(Guid id);
        Task<Position> GetAsync(string name);
        Task<IEnumerable<Position>> BrowseAsync();
        Task AddAsync(Position @position);
        Task UpdateAsync(Position @position);
        Task DeleteAsync(Position @position);
    }
}
