using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PDdotnet1.Models;
namespace PDdotnet1.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        public IActionResult OnPost(Person person)
        {
            return (person.Wiek >= 18) ? RedirectToPage("EqualGreater18", new { imie=person.Imie, nazwisko=person.Nazwisko, plec=person.Plec, wiek=person.Wiek, telefon=person.Telefon, jezykiProgramowania=person.JezykiProgramowania }) : RedirectToPage("Under18");
        }
    }
}
