using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class CouponService : ICouponService
    {
        private readonly IBaseService _baseService;

        public CouponService(IBaseService baseService)
        {
            _baseService = baseService;
        }
        public async Task<ResponseDto?> CreateCouponsAsync(CouponDto coupon)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.POST,
                Data=coupon,
                Url = SD.CouponAPIBase + "/api/Coupon" 
            });
        }

        public async Task<ResponseDto?> DeleteCouponsAsync(int Id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.DELETE,
                Url = SD.CouponAPIBase + "/api/Coupon/" + Id
            });
        }

        public async Task<ResponseDto?> GetCouponByAsc(string couponCode)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupon/GetByCode/" + couponCode
            });
        }

        public async Task<ResponseDto?> GetCouponByIdAsync(int Id)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.GET,
                Url = SD.CouponAPIBase + "/api/Coupon/"+Id
            });
        }

        public async Task<ResponseDto?> GetAllCouponsAsyc()
        {
            return await _baseService.SendAsync(new RequestDto()
                {
                     ApiType = Utility.SD.ApiType.GET,
                      Url=SD.CouponAPIBase+ "/api/Coupon"
            }); 
        } 

        public async Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = Utility.SD.ApiType.PUT,
                Data = couponDto,
                Url = SD.CouponAPIBase + "/api/Coupon"
            });
        } 
    }
}
