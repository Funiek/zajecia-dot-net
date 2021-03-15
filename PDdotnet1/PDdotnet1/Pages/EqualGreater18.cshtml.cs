using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet1.Models;
namespace PDdotnet1.Pages
{
    public class EqualGreater18Model : PageModel
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string plec;
        private int telefon;
        private List<String> jezykiProgramowania;

        [BindProperty(SupportsGet = true)]
        public string Imie { get => imie; set => imie = value; }
        [BindProperty(SupportsGet = true)]
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        [BindProperty(SupportsGet = true)]
        public int Wiek { get => wiek; set => wiek = value; }
        [BindProperty(SupportsGet = true)]
        public string Plec { get => plec; set => plec = value; }
        [BindProperty(SupportsGet = true)]
        public int Telefon { get => telefon; set => telefon = value; }
        [BindProperty(SupportsGet = true)]
        public List<string> JezykiProgramowania { get => jezykiProgramowania; set => jezykiProgramowania = value; }

        public void OnGet()
        {
        }
    }
}
