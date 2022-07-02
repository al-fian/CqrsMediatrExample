using CqrsMediatrExample.Data;
using CqrsMediatrExample.Notifications;
using MediatR;

namespace CqrsMediatrExample.Handlers
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly DataStore _dataStore;

        public EmailHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _dataStore.EventOccured(notification.Product, "Email has been sent");
            await Task.CompletedTask;
        }
    }
}
