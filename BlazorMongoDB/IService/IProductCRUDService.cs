using BlazorMongoDB.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMongoDB.IService
{
    public interface IProductCRUDService
    {
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductById(string id);
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(string id);
    }
}
