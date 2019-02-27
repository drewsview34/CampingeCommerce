using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Models.Interface
{
   public interface ICartProduct
    {
        Task CreateCartItem(CartProduct CartProduct);
        Task DeleteCartProduct(int id);
        Task UpdateCartProduct(CartProduct CartProduct);
        Task<List<CartProduct>> GetCartProductsFromCarts(int cartID, string User);
        Task<Cart> GetCartProductByID(int id);
    }
}
