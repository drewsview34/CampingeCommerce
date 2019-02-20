using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Model.Interface
{
    public interface IInventory:DbContext
    {
        Task CreateInventory(Inventory inventory);
        Task <Inventory>GetIventory(int id);
        Task<IEnumerable<Inventory>> GetInventory();
        Task UpdateInventory(Inventory inventory);
        Task DeleteInventory(int id);

    }
}
