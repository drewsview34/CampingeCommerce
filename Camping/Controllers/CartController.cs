using Camping.Model.Interface;
using Camping.Model.ProductModel;
using Camping.Models;
using Camping.Models.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Controllers
{
    public class CartController:Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private readonly ICart _cart;
        private readonly ICartProduct _cartProduct;
        private IInventory _inventory;
       // private Product _product;

        public CartController(ICart cart,ICartProduct cartProduct,UserManager<ApplicationUser> userManager, IInventory inventory)
        {
            _cart = cart;
            _cartProduct = cartProduct;
            _userManager = userManager;
            _inventory = inventory;
        }
     





    }
}
