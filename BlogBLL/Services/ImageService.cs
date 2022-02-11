using Azure.Storage.Blobs;
using BlogBLL.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogBLL.Services
{
    public class ImageService:IImageService
    {
        private readonly BlobContainerClient _container;
        private readonly string _containerName = "images";

        public ImageService(BlobServiceClient client)
        {
            BlobClientOptions options = new BlobClientOptions();
            _container = client.GetBlobContainerClient(_containerName);
        }

        public async Task<string> Upload(string fileName, Stream file)
        {
            fileName = $"{DateTime.UtcNow.Ticks}-{fileName}";

            var blob = _container.GetBlobClient(fileName);

            var response = await blob.UploadAsync(file);

            if (response.GetRawResponse().Status >= 400)
            {
                throw new System.Exception("Upload failed");
            }

            return fileName;
        }
    }
}
