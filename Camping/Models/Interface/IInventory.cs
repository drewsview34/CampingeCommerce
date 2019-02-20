using Camping.Model.ProductModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Model.Interface
{
    public interface IInventory
    {
        Task CreateInventory(Product inventory);
        Task <Product>GetIventory(int id);
        Task<List<Product>> GetInventory();
        Task UpdateInventory(Product inventory);
        Task DeleteInventory(int id);

    }
}
