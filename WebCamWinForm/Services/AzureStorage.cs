using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.File;
using Microsoft.WindowsAzure.Storage.RetryPolicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCamWinForm.Services
{
    public class AzureStorage
    {
        public static string UploadFile(string connectionString, string fileName, byte[] fileContent)
        {
            var storageAccount = CloudStorageAccount.Parse(connectionString);

            var blobClient = storageAccount.CreateCloudBlobClient();

            blobClient.DefaultRequestOptions.RetryPolicy = new LinearRetry(TimeSpan.FromSeconds(3), 3);

            // Azure Management Portal says (26 January 2016):
            // Container names can contain only lowercase letters, numbers, and hyphens, and must begin with a letter or a number. 
            // The name can't contain two consecutive hyphens.
            string containerName = "webcam-videos";
            var videosBlobContainer = blobClient.GetContainerReference(containerName);

            // Create a new container, if it does not exist
            videosBlobContainer.CreateIfNotExists();

            var perm = new BlobContainerPermissions();
            perm.PublicAccess = BlobContainerPublicAccessType.Container;
            videosBlobContainer.SetPermissions(perm);

            var video = videosBlobContainer.GetBlockBlobReference(fileName);

            video.UploadFromByteArray(fileContent, 0, fileContent.Length);

            return video.Uri.ToString();
        }
    }
}
