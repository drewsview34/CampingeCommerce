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


        public async Task<IActionResult> Index()
        {
            return View(await _context.GetInventory());
        }

    }
}
