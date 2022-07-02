using CqrsMediatrExample.Commands;
using CqrsMediatrExample.Data;
using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdCommand, Product>, IGetProductByIdHandler
    {
        private readonly DataStore _dataStore;

        public GetProductByIdHandler(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Product> Handle(GetProductByIdCommand request, CancellationToken cancellationToken)
        {
            return await _dataStore.GetAProductById(request.Id);
        }
    }
}
