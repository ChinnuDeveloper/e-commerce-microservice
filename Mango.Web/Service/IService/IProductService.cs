using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface IProductService
    {
        Task<ResponseDto?> GetProductByNameAsc(string productName);
        Task<ResponseDto?> GetAllProductsAsyc();
        Task<ResponseDto?> GetProductsByIdAsync(int Id);
        Task<ResponseDto?> CreateProductsAsync(ProductDto product);
        Task<ResponseDto?> UpdateProductsAsync(ProductDto product);
        Task<ResponseDto?> DeleteProductsAsync(int Id);
    }
}
