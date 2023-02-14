using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Abstractions.StorageAbs.LocalStorageAbs;

namespace WebSite.Infrastructure.Services.Strorage.Local
{


    public class LocalStrorage : ILocalStorage
    {
        readonly IWebHostEnvironment _webHostEnvironment;

        public LocalStrorage(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        async Task<bool> CopyFileAsync(string path, IFormFile file)
        {
            try
            {
                using FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, useAsync: false);
                await file.CopyToAsync(fileStream);
                await fileStream.FlushAsync();
                return true;
            }
            catch(Exception copyfileex)
            {
                throw copyfileex;
            }
        }

        public async Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files)
        {
            string upPath = Path.Combine(_webHostEnvironment.WebRootPath, path);

            if (!Directory.Exists(upPath))
                Directory.CreateDirectory(upPath);

            List<(string fileName, string path)> datas = new(); 

            foreach (IFormFile file in files)
            {
                await CopyFileAsync($"{upPath}\\{file.Name}", file);
                datas.Add((file.Name, $"{path}\\{file.Name}"));
            }

            return datas;
        }

        public List<string> GetFiles(string path)
        {
            DirectoryInfo directory= new DirectoryInfo(path);
            return directory.GetFiles().Select(x => x.Name).ToList();
        }

        public bool HasFile(string path, string fileName)
        => File.Exists($"{path}\\{fileName}");

        public void Delete(string path, string fileName)
        => File.Delete($"{path}\\{fileName}");
    }
}
