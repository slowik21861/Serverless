using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace BlobFunc
{
    public static class BlobFunc
    {
        [FunctionName("BlobFunc")]
        public static void Run([BlobTrigger("samples-workitems/{name}", Connection = "BlobConnString")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
