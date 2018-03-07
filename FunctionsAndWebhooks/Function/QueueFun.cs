using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionsAndWebhooks.Function
{
    public static class QueueFun
    {
        [FunctionName("QueueFun")]
        public static void Run([QueueTrigger("functionqueue", Connection = "AzureWebJobsStorage")]string myQueueItem, TraceWriter log)
        {
            log.Info($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
