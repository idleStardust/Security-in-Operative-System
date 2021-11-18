using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Contracts
{
    public interface IAccessor<Model>
    {
        Task<Model> FindAsync(int id);
        Task<IList<Model>> GetAsync();
        Task UpdateAsync(Model item);
        Task AddAsync(Model item);
    }
}
