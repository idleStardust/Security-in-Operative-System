using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Globalization;
using Data.Contracts;

namespace Data.Accessors
{
    public class ZipAccessor : IZipAccessor
    {
        public ZipAccessor() { }

        public async Task AddAsync(ZipArchive item)
        {
            await Task.Run(() =>
            {
                try
                {
                    item.ExtractToDirectory("./temp/");
                    System.IO.DirectoryInfo di = new DirectoryInfo("./temp/");

                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"ZIPBOMB! Finished on {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
                    Console.ResetColor();
                    Environment.Exit(1);
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Finished on {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
                Console.ResetColor();
            });
        }

        public Task<ZipArchive> FindAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ZipArchive>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ZipArchive item)
        {
            throw new NotImplementedException();
        }
    }
}
