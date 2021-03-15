using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PDdotnet2.Models;

namespace PDdotnet2.Pages
{
    public class KalkulatorModel : PageModel
    {
        [BindProperty]
        public Person person { get; set; }

        public double _wzrost;

        public double _waga;

        public double _BMI;

        public string _wiadomowsc;

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            _wiadomowsc = "brak";
            _wzrost = double.Parse(person.wzrost);
            _waga = double.Parse(person.waga);
            _wzrost = (person.miara.Equals("m")) ? _wzrost : (_wzrost / 100);
            _BMI = _waga / (_wzrost * _wzrost);
            _BMI = Math.Round(_BMI, 2);
            Console.WriteLine(person.waga);
            Console.WriteLine(_BMI);
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (_BMI < 18.5) _wiadomowsc = "niedowaga";
            else if (_BMI >= 18.6 && _BMI <= 25) _wiadomowsc = "waga prawid³owa";
            else if (_BMI >= 26 && _BMI <= 30) _wiadomowsc = "nadwaga";
            else if (_BMI >= 30 && _BMI <= 34.9) _wiadomowsc = "oty³oœæ";
            else if (_BMI >= 35 && _BMI <= 39.9) _wiadomowsc = "oty³oœæ II stopnia";
            else _wiadomowsc = "oty³oœæ olbrzymia";
            return RedirectToPage("Result", new { imie = person.imie, email = person.email, wiek = person.wiek, plec = person.plec, BMI = _BMI, wiadomosc = _wiadomowsc });
        }
    }
}
