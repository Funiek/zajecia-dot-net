using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet3.Models;
using System.Text.Json;

namespace PDdotnet3.Pages
{
    public class KoszykModel : MyPageModel
    {
        public List<Product> cookieList;

        public string[] item;

        public void OnGet()
        {
            LoadDB();
            cookieList = new List<Product>();
            foreach(var itemKey in Request.Cookies.Keys)
            {
                if (!itemKey[0].Equals('.'))
                {
                    cookieList.Add(JsonSerializer.Deserialize<Product>(Request.Cookies[itemKey]));
                }
            }
            SaveDB();
            
        }
        public IActionResult OnPost()
        {
            foreach(var itemKey in Request.Cookies.Keys)
            {
                if (!itemKey.StartsWith(".")) Response.Cookies.Delete(itemKey); ;
            }
            return RedirectToPage("Koszyk");
        }
    }
}
