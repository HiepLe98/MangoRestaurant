using Mango.Services.ProductAPI.Models;

namespace Mango.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<ProductDto> UpdateProduct(ProductDto productDto);
        Task<bool> DeleteProductById(int productId);
           
    }
}
