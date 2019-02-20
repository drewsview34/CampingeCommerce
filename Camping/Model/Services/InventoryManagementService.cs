using Camping.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Model.Services
{
    public class InventoryManagementService : IInventory
    {
        
        public Task CreateInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInventory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Inventory>> GetInventory()
        {
            throw new NotImplementedException();
        }

        public Task<Inventory> GetIventory(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateInventory(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}
