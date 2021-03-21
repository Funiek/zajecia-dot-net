using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet3.Models;
using System.Text.Json;

namespace PDdotnet3.Pages
{
    public class CreateCookieKoszykModel : MyPageModel
    {
        public Product product { get; set; }

        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        public IActionResult OnGet()
        {
            LoadDB();
            product = productDB.GetProductById(id);
            Response.Cookies.Append(id.ToString(), JsonSerializer.Serialize(product));
            SaveDB();
            return RedirectToPage("Details", new { id=id });
        }
    }
}
