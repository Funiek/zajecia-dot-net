using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet3.Models;
using System.Web;

namespace PDdotnet3.Pages
{
    public class ListModel : MyPageModel
    {
        public List<Product> productList;
        public void OnGet()
        {
            LoadDB();
            productList = productDB.List();
            SaveDB();
        }
    }
}
