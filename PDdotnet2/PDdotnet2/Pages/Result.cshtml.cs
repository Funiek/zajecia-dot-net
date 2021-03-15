using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PDdotnet2.Pages
{
    public class ResultModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string imie { get; set; }

        [BindProperty(SupportsGet = true)]
        public string email { get; set; }

        [BindProperty(SupportsGet = true)]
        public int wiek { get; set; }

        [BindProperty(SupportsGet = true)]
        public string plec { get; set; }

        [BindProperty(SupportsGet = true)]
        public double BMI { get; set; }

        [BindProperty(SupportsGet = true)]
        public string wiadomosc { get; set; }


        public void OnGet()
        {
            Console.WriteLine($"{wiadomosc} brr");
        }
    }
}
