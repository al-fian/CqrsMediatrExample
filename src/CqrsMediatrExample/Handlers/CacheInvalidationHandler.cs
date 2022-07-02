using CqrsMediatrExample.Data;
using CqrsMediatrExample.Notifications;
using MediatR;

namespace CqrsMediatrExample.Handlers
{
    public class CacheInvalidationHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly DataStore _dataStore;

        public CacheInvalidationHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _dataStore.EventOccured(notification.Product, "Cache has been invalidated");
            await Task.CompletedTask;
        }
    }
}
