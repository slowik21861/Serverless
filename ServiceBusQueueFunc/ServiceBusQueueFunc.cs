using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusQueueFunc
{
    public static class ServiceBusQueueFunc
    {
        [FunctionName("ServiceBusQueueFunc")]
        public static void Run([ServiceBusTrigger("myqueue", Connection = "SBQConnString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
