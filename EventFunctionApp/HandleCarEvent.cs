using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.WebJobs.ServiceBus;

namespace EventFunctionApp
{
    public static class HandleCarEvent
    {
        [FunctionName("HandleCarEvent")]
        public static void Run([EventHubTrigger("marparcarfleet", Connection = "cs", ConsumerGroup ="function1")]string myEventHubMessage, TraceWriter log)
        {

            log.Info($"C# Event Hub trigger function processed a message: {myEventHubMessage}");
        }
    }
}
