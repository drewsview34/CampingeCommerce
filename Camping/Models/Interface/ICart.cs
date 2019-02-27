using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Models.Interface
{
    public interface ICart
    {
        Task CreateCart(Cart cart);
        Task DeleteCart(int id);
        Task UpdateCart(Cart cart);
        Task<List<Cart>> GetCarts();
        Task<Cart> GetCartByID(int id);
    }
}
