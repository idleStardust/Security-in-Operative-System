using System.Threading.Tasks;
using Managers.Implementation;
using Microsoft.AspNetCore.Http;

namespace Managers.Contracts
{
    public interface IZipManager : IManager
    {
        Task DecompressAsync(IFormFile zipFile);
    }
}
