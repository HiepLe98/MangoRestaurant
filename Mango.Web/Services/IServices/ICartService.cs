using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface ICartService : IBaseService
    {
        Task<T> GetCartByUserIdAsnyc<T>(string userId, string token = null);
        Task<T> AddToCartAsync<T>(CartDto cartDto, string token = null);
        Task<T> UpadateCartAsync<T>(CartDto cartDto, string token = null);
        Task<T> RemoveFromCartAsync<T>(int cartId, string token = null);
    }
}
