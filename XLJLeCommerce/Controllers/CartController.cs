﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XLJLeCommerce.Data;
using XLJLeCommerce.Models;
using XLJLeCommerce.Models.Interfaces;

namespace XLJLeCommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly ICart _cart;
        private readonly IShoppingCartItem _shoppingCartItem;
        private UserManager<ApplicationUser> _userManager;
        /// <summary>
        /// cartcontroller constructor 
        /// </summary>
        /// <param name="cart">cart table</param>
        /// <param name="shoppingCartItem">shoppingcartitem table</param>
        /// <param name="userManager">identitdy table</param>
        public CartController(ICart cart, IShoppingCartItem shoppingCartItem, UserManager<ApplicationUser> userManager)
        {
            _cart = cart;
            _userManager = userManager;
            _shoppingCartItem = shoppingCartItem;
        }

        /// <summary>
        /// default page for shopping cart, shows all items to page
        /// </summary>
        /// <returns>page to see all items</returns>
        public async Task<IActionResult> Index()

        {
            //find userID
            if (User.Identity.Name != null)
            {
                string userEmail = User.Identity.Name;
                var user = await _userManager.FindByEmailAsync(userEmail);
                string userID = user.Id;

                //so can find their carts
                Cart cartObj = await _cart.GetCart(userID);

                return View(await _shoppingCartItem.GetAllShoppingCartItems(cartObj.ID));
            }
            else //user not in DB
            {
                return RedirectToAction("Register", "Account");
            }
        }

        /// <summary>
        /// gets page for editing
        /// </summary>
        /// <param name="id">which shoping cart item</param>
        /// <returns>the product edit page</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var scItem = await _shoppingCartItem.GetShoppingCartItem(id);
            if (scItem == null)
            {
                return NotFound();
            }
            return View(scItem);
        }

        /// <summary>
        /// updates the qty for an item in the shoping cart
        /// </summary>
        /// <param name="id">id of the item</param>
        /// <param name="cartItem">shoppingcart object</param>
        /// <returns>to the page after it does the update</returns>
        [HttpPost]
        public async Task<IActionResult> EditItem(int id, [Bind("ID, CartID ProductID, ProdQty")] ShoppingCartItem cartItem)
        {
            int qty = cartItem.ProdQty;
            await _shoppingCartItem.UpdateShoppingCartItem(id,qty);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// deletes a shoping cart item
        /// </summary>
        /// <param name="id">which item to delete</param>
        /// <returns>the home page after it delete from table</returns>
        [HttpGet]
        public async Task<IActionResult> DeleteItem(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            await _shoppingCartItem.DeleteShoppingCartItem((int)id);
            return RedirectToAction(nameof(Index));
        }

    }
}
