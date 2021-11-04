using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Contracts
{
    public interface IAccessor<Model> where Model : IModel<Model>
    {
        Task<Model> Get(int id);
        Task<IList<Model>> GetAll();
        Task Put(Model model);
        Task Post(Model model);
    }
}
