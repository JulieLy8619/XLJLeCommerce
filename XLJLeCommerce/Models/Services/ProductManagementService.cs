﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XLJLeCommerce.Data;
using XLJLeCommerce.Models.Interfaces;

namespace XLJLeCommerce.Models.Services
{
    public class ProductManagementService : Iproduct
    {
        private CreaturesDbcontext _context { get; }

        /// <summary>
        /// ProductManagementService constructor bring in the creaturesDbcontext
        /// </summary>
        /// <param name="context">the database</param>
        public ProductManagementService(CreaturesDbcontext context)
        {
            _context = context;
        }

        /// <summary>
        /// adds a product to the database
        /// </summary>
        /// <param name="product">the product to be added</param>
        /// <returns>the task when done</returns>
        public async Task Create(Product product)
        {
            if (await _context.Products.FirstOrDefaultAsync(p => p.ID == product.ID) == null)
            {
                _context.Products.Add(product);
            }
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// get one product
        /// </summary>
        /// <param name="id">which product</param>
        /// <returns>the specific product</returns>
        public async  Task<Product> GetProduct(int id)
        {
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.ID == id);
            return product;
        }

        /// <summary>
        /// get all products
        /// </summary>
        /// <returns>a list of all the products in the table</returns>
        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        /// <summary>
        /// update one product and if it doesn't exist it will add it
        /// </summary>
        /// <param name="product">the product with the updated information</param>
        /// <returns>when the task is completed</returns>
        public async Task UpdateProduct(Product product)
        {

            if (await _context.Products.FirstOrDefaultAsync(p => p.ID == product.ID) == null)
            {
                _context.Products.Add(product);
            }

            else
            {  
                _context.Products.Update(product);
            }
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// delete the specific product by the product id
        /// </summary>
        /// <param name="id">which product</param>
        /// <returns>when the task is done</returns>
        public async Task DeleteProduct(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

        }
    }
}
