using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet3.Models;

namespace PDdotnet3.Pages
{
    public class DeleteModel : MyPageModel
    {
        public IActionResult OnGet(int id)
        {
            LoadDB();
            productDB.Delete(id);
            SaveDB();
            return RedirectToPage("List");
        }
    }
}
