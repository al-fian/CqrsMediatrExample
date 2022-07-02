using CqrsMediatrExample.Commands;
using CqrsMediatrExample.Models;

namespace CqrsMediatrExample.Handlers
{
    public interface IGetProductByIdHandler
    {
        Task<Product> Handle(GetProductByIdCommand request, CancellationToken cancellationToken);
    }
}