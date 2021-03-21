using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet3.Models;

namespace PDdotnet3.Pages
{
    public class CreateModel : MyPageModel
    {
        [BindProperty]
        public Product newProduct { get; set; }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost()
        {
            LoadDB();
            productDB.Create(newProduct);
            SaveDB();
            return RedirectToPage("List");
        }
    }
}
