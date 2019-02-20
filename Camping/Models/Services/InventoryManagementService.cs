using Camping.Data;
using Camping.Model.Interface;
using Camping.Model.ProductModel;
using Microsoft.EntityFrameworkCore;
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

        public async Task CreateInventory(Product inventory)
        {
            _context.Add(inventory);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInventory(int id)
        {
            Product inventory = await _context.Inventory.FindAsync(id);
            if (inventory != null && inventory.ID == id)
            {
                _context.Remove(inventory);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Product>> GetInventory()
        {
            return await _context.Inventory.ToListAsync();
        }

        public async Task<Product> GetIventory(int id)
        {
            return await _context.Inventory.FirstOrDefaultAsync(inventory => inventory.ID == id);
        }
    

        public async Task UpdateInventory(Product inventory)
        {
            _context.Update(inventory);
            await _context.SaveChangesAsync();
        }
    }
}
