using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zajecia1.Models;
namespace Zajecia1.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }

        public IActionResult OnPost(Person person)
        {
            //string _imie = Request.Form["firstName"];
            //string _nazwisko = Request.Form["lastName"];
            return RedirectToPage("Welcome",new {firstName=person.firstName, lastName=person.lastName});
        }
    }
}
