using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zajecia1.Models;
namespace Zajecia1.Pages
{
    public class WelcomeModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string firstName { get; set; }

        [BindProperty(SupportsGet = true)]
        public string lastName { get; set; }

        /*public void OnGet(Person person)
        {
            firstName = person.firstName;
            lastName = person.lastName;
        }*/

        public void OnGet()
        {
        }
    }
}
