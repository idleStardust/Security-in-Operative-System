using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using Managers.Contracts;
using Microsoft.AspNetCore.Http;

namespace Managers.Implementation
{
    public class ZipManager : IZipManager
    {
        public async Task Decompress(IFormFile zipFile)
        {
            if (zipFile.ContentType != "application/zip")
                await Task.FromException(new Exception("File must be of type Zip."));

            using (ZipArchive archive = new ZipArchive(zipFile.OpenReadStream()))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    Console.WriteLine(entry.Name);
                    //entry.ExtractToFile($"./temp/{entry.Name}");
                }
            }

        }
    }
}