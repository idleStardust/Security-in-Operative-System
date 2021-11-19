using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Contracts
{
    public interface IAccessor<Model>
    {
        /// <summary>
        /// Finds single <Model> with given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns><Model> with given id</returns>
        Task<Model> FindAsync(int id);
        /// <summary>
        /// Gets all <Model>s.
        /// </summary>
        /// <returns>List of <Model>s</returns>
        Task<IList<Model>> GetAsync();
        /// <summary>
        /// Updates data of <Model> with given id.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>State of Action</returns>
        Task UpdateAsync(Model item);
        /// <summary>
        /// Adds a <Model>.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>State of Action</returns>
        Task AddAsync(Model item);
    }
}
