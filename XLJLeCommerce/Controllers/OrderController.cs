﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using XLJLeCommerce.Data;
using XLJLeCommerce.Models;
using XLJLeCommerce.Models.Interfaces;

namespace XLJLeCommerce.Controllers
{
    public class OrderController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private readonly IOrder _order;
        private readonly CreaturesDbcontext _context;

        /// <summary>
        /// access to other tables
        /// </summary>
        /// <param name="userManager">identity table</param>
        /// <param name="order">order table</param>
        public OrderController(UserManager<ApplicationUser> userManager, IOrder order, CreaturesDbcontext context)
        {
            _userManager = userManager;
            _order = order;
            _context = context;
        }

        /// <summary>
        /// find what user it is now, and find the user's order with the email
        /// </summary>
        /// <returns>the order home page</returns>
        public async Task<IActionResult> Index()
        {
            string userEmail = User.Identity.Name;
            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user != null)
            {
                string userID = user.Id;
                var res = _context.OrderTable.Where(o => o.UserID == userID);
                return View(res);
            }

            return View();
        }
    }
}