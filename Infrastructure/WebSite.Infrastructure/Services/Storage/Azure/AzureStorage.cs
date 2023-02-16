using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using WebSite.Application.Abstractions.StorageAbs.AzureAbs;

namespace WebSite.Infrastructure.Services.Storage.Azure
{
    public class AzureStorage : IAzureStorage
    {
        readonly BlobServiceClient _blobServiceClient;
        BlobContainerClient _blobContainerClient;
        public AzureStorage(IConfiguration configuration)
        {
            _blobServiceClient = new(configuration["Storage:Azure"]);
        }

        public async Task<List<(string fileName, string path)>> UploadAsync(string path, IFormFileCollection files)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(path);
            await _blobContainerClient.CreateIfNotExistsAsync();
            await _blobContainerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);

            List<(string fileName, string path)> datas = new();
            foreach (var item in files)
            {
                BlobClient blobClient = _blobContainerClient.GetBlobClient(item.Name);
                await blobClient.UploadAsync(item.OpenReadStream());
                datas.Add((item.Name, path));
            }
            return datas;
        }

        public async void Delete(string path, string fileName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(path);
            BlobClient blobClient =_blobContainerClient.GetBlobClient(fileName);
            await blobClient.DeleteAsync();
        }

        public List<string> GetFiles(string path)
        {

            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(path);
            return _blobContainerClient.GetBlobs().Select(b => b.Name).ToList();
        }

        public bool HasFile(string path, string fileName)
        {
            _blobContainerClient = _blobServiceClient.GetBlobContainerClient(path);
            return _blobContainerClient.GetBlobs().Any(b => b.Name == fileName);
        }


    }
}
