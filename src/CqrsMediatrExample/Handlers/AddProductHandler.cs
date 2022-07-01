using CqrsMediatrExample.Commands;
using CqrsMediatrExample.Data;
using MediatR;

namespace CqrsMediatrExample.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly DataStore _dataStore;

        public AddProductHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.AddProduct(request.Product);

            return Unit.Value;
        }
    }
}
