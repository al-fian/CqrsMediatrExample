using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatrExample.Controllers
{
    public interface IProductsController
    {
        Task<ActionResult> GetAllProducts();
    }
}