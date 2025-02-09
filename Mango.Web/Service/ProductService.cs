using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class ProductService : IProductService
    {
        private readonly IBaseService _baseService;

        public ProductService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateProductsAsync(ProductDto product)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.POST,
                Data = product,
                Url = SD.ProductAPIBase + "/api/Product"
            }); 
        }

        public async Task<ResponseDto?> DeleteProductsAsync(int Id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.DELETE, 
                Url = SD.ProductAPIBase + "/api/Product/"+Id
            }); 
        }

        public async Task<ResponseDto?> GetAllProductsAsyc()
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET, 
                Url = SD.ProductAPIBase + "/api/Product"
            }); 
        }

        public async Task<ResponseDto?> GetProductByNameAsc(string productName)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET, 
                Url = SD.ProductAPIBase + "/api/Product/GetByName/"+ productName
            }); 
        }

        public async Task<ResponseDto?> GetProductsByIdAsync(int Id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.ProductAPIBase + "/api/Product/" + Id
            });
        }

        public async Task<ResponseDto?> UpdateProductsAsync(ProductDto product)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.PUT,
                Data = product,
                Url = SD.ProductAPIBase + "/api/Product"
            });
        }
    }
}
