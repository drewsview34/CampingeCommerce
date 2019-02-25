using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Controllers
{
    [Authorize(Policy = "UserEmailOnly")]
    /// what am thinking here is to forbid users under 18 to use creditcards
    public class PolicyController:Controller
    {
        public IActionResult Index()

        {
            return View();
        }

       
    }
}
