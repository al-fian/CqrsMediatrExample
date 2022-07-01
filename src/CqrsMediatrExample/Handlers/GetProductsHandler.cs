using CqrsMediatrExample.Data;
using CqrsMediatrExample.Models;
using CqrsMediatrExample.Queries;
using MediatR;

namespace CqrsMediatrExample.Handlers
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly DataStore _dataStore;

        public GetProductsHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _dataStore.GetAllProducts();
        }
    }
}
