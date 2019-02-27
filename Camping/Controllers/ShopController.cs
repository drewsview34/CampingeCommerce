using Camping.Model.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Controllers
{
    public class ShopController : Controller
    {

        private IInventory _context { get; }


        public ShopController(IInventory db)
        {
            _context = db;
        }

        /// <summary>
        /// /Shop
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetInventory());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await _context.GetIventory(id));
        }

    }
}
