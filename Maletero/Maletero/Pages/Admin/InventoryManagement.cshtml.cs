using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maletero.Pages.Admin
{
    public class InventoryManagementModel : PageModel
    {
        private readonly IInventory _product;

        [FromRoute]
        public int ID { get; set; }

        public Product Product { get; set; }

        public InventoryManagementModel(IInventory product)
        {
            _product = product;
        }

        /// <summary>
        /// Gets a product
        /// </summary>
        /// <returns>post</returns>
        public async Task OnGet()
        {
            //if there's no post, create a new one
            Product = await _product.GetbyID(ID) ?? new Product();
        }

        /// <summary>
        /// Posts a product
        /// </summary>
        /// <returns>post</returns>
        public async Task<IActionResult> OnPost()
        {
            //call to db with the ID
            //if there is no post, create a new one
            var prod = await _product.GetbyID(ID) ?? new Product();

            //set data from the db to the new data from Post/user input
            prod.ID = Product.ID;
            prod.Image = Product.Image;
            prod.SKU = Product.SKU;
            prod.Name = prod.Name;
            prod.Price = prod.Price;

            //save the post to the db
            await _product.SaveAsync(prod);

            return RedirectToPage("/Index");
        }

        /// <summary>
        /// Delete a post
        /// </summary>
        /// <returns>home page</returns>
        public async Task<IActionResult> OnPostDelete()
        {
            await _product.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");
        }
    }
}