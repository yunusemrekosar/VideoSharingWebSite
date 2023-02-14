using Microsoft.AspNetCore.Http;

namespace WebSite.Application.Abstractions.StorageAbs
{
    public interface IStorage
    {
        Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files); 

        void Delete(string path, string fileName);

        List<string> GetFiles(string path);

        bool HasFile(string path, string fileName);
    }
}
