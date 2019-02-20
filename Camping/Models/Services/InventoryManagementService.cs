using Camping.Data;
using Camping.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Model.Services
{
    public class InventoryManagementService : IInventory
    {
       private CampingDbContext _context { get; }
        public InventoryManagementService(CampingDbContext context)
        {
            _context = context;
        }
        public async Task CreateInventory(Inventory inventory)
        {
            _context.Inventory.Add(Inventory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInventory(int id)
        {
            Inventory inventory = _context.Inventory.FirstOrDefault(i => i.id == id);
            _context.Inventory.Remove(Inventory);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Inventory>> GetInventory()
        {
            return await _context.Inventory.ToListAsync();
        }

        public async Task<Inventory> GetIventory(int id)
        {
            return await _context.Inventory.FirstOrDefaultAsync(inventory => inventory.ID == id);
        }
    

        public async Task UpdateInventory(Inventory inventory)
        {
            _context.Inventory.Update(inventory);
            await _context.SaveChangesAsync();
        }
    }
}
