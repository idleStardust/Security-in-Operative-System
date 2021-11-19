using System.Threading.Tasks;
using System;
using Managers.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    /// <summary>
    /// Controller For Zip Management
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ZipController : ControllerBase
    {
        private readonly IZipManager manager;
        public ZipController(IZipManager manager)
        {
            this.manager = manager;
        }
        /// <summary>
        /// Decompresses posted zipFile
        /// </summary>
        /// <param name="zipFile"></param>
        /// <returns></returns>
        [HttpPost]
        [RequestFormLimits(MultipartBodyLengthLimit = 20971520000)]
        [RequestSizeLimit(20971520000)]
        public Task Post(IFormFile zipFile) => manager.DecompressAsync(zipFile);
        /// <summary>
        /// Sends example String
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<String> GetAll() => Task.FromResult("Hola XML no te queremos");
    }
}