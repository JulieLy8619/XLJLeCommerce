﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XLJLeCommerce.Data;
using XLJLeCommerce.Models;
using XLJLeCommerce.Models.Interfaces;

namespace XLJLeCommerce.Controllers
{
    [Authorize(Policy = "Over3minOnly")]
    public class PolicyController : Controller
    {
        private readonly Iproduct _product;
        private UserManager<ApplicationUser> _userManager;
       
        /// <summary>
        /// access to other tables
        /// </summary>
        /// <param name="product">product table</param>
        /// <param name="userManager">identity table</param>
        public PolicyController(Iproduct product, UserManager<ApplicationUser> userManager)
        {
            _product = product;
            _userManager = userManager;
        }

        /// <summary>
        /// calls the index page for vip users
        /// </summary>
        /// <returns>the page</returns>
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// gets the vip page for vip users
        /// </summary>
        /// <returns>the page</returns>
        [Authorize]
        public async Task<IActionResult> VIPProd()
        {
            return View(await _product.GetAllProducts());         
        }
    
    }
}
