using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet3.Models;

namespace PDdotnet3.Pages
{
    public class EditModel : MyPageModel
    {
        [BindProperty]
        public Product product { get; set; }
        public void OnGet(int id)
        {
            LoadDB();
            product = productDB.GetProductById(id);
            SaveDB();
        }

        public IActionResult OnPost()
        {
            LoadDB();
            productDB.ModifyProduct(product);
            SaveDB();
            return RedirectToPage("List");
        }
    }
}
