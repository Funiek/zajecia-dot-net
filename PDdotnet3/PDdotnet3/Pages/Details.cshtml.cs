using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet3.Models;

namespace PDdotnet3.Pages
{
    public class DetailsModel : MyPageModel
    {
        public Product product { get; set; }

        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public void OnGet()
        {
            LoadDB();
            product = productDB.GetProductById(id);
            SaveDB();
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("List");
        }
    }
}
