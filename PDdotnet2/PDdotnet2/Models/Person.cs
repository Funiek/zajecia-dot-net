using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace PDdotnet2.Models
{
    public class Person
    {
        [Display(Name = "Imię")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "pole musi składać się z liter i zaczynać się z dużej litery")]
        [StringLength(15, ErrorMessage = "pole może zawierać maksymalnie 15 znaków")]
        [Required(ErrorMessage = "pole 'Imię' jest obowiązkowe")]
        public string imie { get; set; }

        [Display(Name = "Email")]
        [RegularExpression(@"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "pole 'Email' musi mieć format adresu email")]
        [Required(ErrorMessage = "pole 'Email' jest obowiązkowe")]
        public string email { get; set; }

        [Display(Name = "Wiek")]
        [Range(1, 120, ErrorMessage = "Podaj liczbę z przedziału 1-120")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Podaj liczbę!")]
        public int wiek { get; set; }

        [Display(Name = "Waga")]
        [RegularExpression(@"^[0-9]*(?:\,[0-9]*)?$", ErrorMessage = "Podaj liczbę!")]
        [Required(ErrorMessage = "pole 'Waga' jest obowiązkowe")]
        public string waga { get; set; }

        [Display(Name = "Wzrost")]
        [RegularExpression(@"^[0-9]*(?:\,[0-9]*)?$", ErrorMessage = "Podaj liczbę!")]
        [Required(ErrorMessage = "pole 'Wzrost' jest obowiązkowe")]
        public string wzrost { get; set; }

        public string plec { get; set; }

        public string miara { get; set; }
    }
}
