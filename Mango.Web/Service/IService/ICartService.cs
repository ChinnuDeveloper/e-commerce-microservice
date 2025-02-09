using Mango.Web.Models;

namespace Mango.Web.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartByUserIdAsc(string userId);
        Task<ResponseDto?> UpsertCartAsyc(CartDto cartDto);
        Task<ResponseDto?> RemoveFromCartAsync(int cartDetailsId);
        Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto);        
    }
}
