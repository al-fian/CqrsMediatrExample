using CqrsMediatrExample.Models;

namespace CqrsMediatrExample.Data
{
    public interface IDataStore
    {
        Task AddProduct(Product product);
        Task<IEnumerable<Product>> GetAListOfProducts();
    }
}