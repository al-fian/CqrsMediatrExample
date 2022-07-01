using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Commands
{
    public record AddProductCommand(Product Product) : IRequest;
}
