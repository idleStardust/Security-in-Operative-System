using System.Threading.Tasks;
using Managers.Implementation;
using Microsoft.AspNetCore.Http;

namespace Managers.Contracts
{
    public interface IZipManager : IManager
    {
        /// <summary>
        /// Decompresses given zipFile
        /// </summary>
        /// <param name="zipFile"></param>
        /// <returns>Result of ZipFile decompress action</returns>
        Task DecompressAsync(IFormFile zipFile);
    }
}
