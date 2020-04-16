using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace QueueFunc
{
    public static class QueueFunc
    {
        [FunctionName("QueueFunc")]
        public static void Run([QueueTrigger("myqueue-items", Connection = "QueueConnString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
