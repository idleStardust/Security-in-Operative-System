using System;
using System.IO.Compression;
using System.Threading.Tasks;
using Data.Contracts;
using Managers.Contracts;
using Microsoft.AspNetCore.Http;

namespace Managers.Implementation
{
    public class ZipManager : IZipManager
    {
        private readonly IZipAccessor zipAccessor;
        public ZipManager(IZipAccessor zipAccessor)
        {
            this.zipAccessor = zipAccessor;
        }
        public async Task DecompressAsync(IFormFile zipFile)
        {
            if (zipFile.ContentType != "application/zip")
                await Task.FromException(new Exception("File must be of type Zip."));

            ZipArchive archive = new ZipArchive(zipFile.OpenReadStream());
            
            await zipAccessor.AddAsync(archive);
            
        }
    }
}