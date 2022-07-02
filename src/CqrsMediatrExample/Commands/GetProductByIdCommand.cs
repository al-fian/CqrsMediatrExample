using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Commands
{
    public record GetProductByIdCommand(int Id) : IRequest<Product>, IGetProductByIdCommand;
}
