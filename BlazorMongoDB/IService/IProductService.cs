using BlazorMongoDB.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMongoDB.IService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetFeaturedProducts();
       
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(string id);
        Task<Product> GetProductById(string id); // Método para obtener producto por ID

    }
}
