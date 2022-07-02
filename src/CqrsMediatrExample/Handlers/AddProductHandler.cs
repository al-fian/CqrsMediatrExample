using CqrsMediatrExample.Commands;
using CqrsMediatrExample.Data;
using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly DataStore _dataStore;

        public AddProductHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _dataStore.AddProduct(request.Product);

            return request.Product;
        }
    }
}
