using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite.Application.Abstractions.StorageAbs;

namespace WebSite.Infrastructure.Services.Storage
{
    public class StorageService : IStorageService
    {
        readonly IStorage _storage;

        public StorageService(IStorage storage)
        {
            _storage = storage;
        }

        public void Delete(string path, string fileName)
        => _storage.Delete(path, fileName);

        public List<string> GetFiles(string path)
        => _storage.GetFiles(path);

        public bool HasFile(string path, string fileName)
        => _storage.HasFile(path, fileName);

        public async Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files)
        => await _storage.UploadAsync(path, files);
    }
}
