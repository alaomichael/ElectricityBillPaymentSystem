using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

namespace ElectricityBillPaymentSystem.Events
{
    public class EventPublisher
    {
        private readonly IAmazonSimpleNotificationService _snsClient;

        public EventPublisher(IAmazonSimpleNotificationService snsClient)
        {
            _snsClient = snsClient;
        }

        public async Task Publish(string eventName, object data)
        {
            var publishRequest = new PublishRequest
            {
                TopicArn = "YOUR_TOPIC_ARN",
                Message = JsonConvert.SerializeObject(data),
                Subject = eventName
            };
            await _snsClient.PublishAsync(publishRequest);
        }
    }
}
