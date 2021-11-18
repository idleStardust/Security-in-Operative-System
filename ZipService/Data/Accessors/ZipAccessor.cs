using System;
using System.IO;
using System.Collections.Generic;
using System.IO.Compression;
using System.Threading.Tasks;
using Data.Contracts;

namespace Data.Accessors
{
    public class ZipAccessor : IZipAccessor
    {
        public ZipAccessor()
        {
        }

        public async Task AddAsync(ZipArchive item)
        {
            await Task.Run(() =>
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
