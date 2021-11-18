using System.Threading.Tasks;
using Managers.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZipController : ControllerBase
    {
        private readonly IZipManager manager;
        public ZipController(IZipManager manager)
        {
            this.manager = manager;
        }

        [HttpPost]
        public async Task Post(IFormFile zipFile) => await manager.Decompress(zipFile);
    }

}