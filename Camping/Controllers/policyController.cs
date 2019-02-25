using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Controllers
{
    [Authorize]
    public class policyController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
