using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDdotnet1.Models
{
    public class Person
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string plec;
        private int telefon;
        private List<String> jezykiProgramowania;

        public string Imie { get => imie; set => imie = value; }
        public string Nazwisko { get => nazwisko; set => nazwisko = value; }
        public int Wiek { get => wiek; set => wiek = value; }
        public string Plec { get => plec; set => plec = value; }
        public int Telefon { get => telefon; set => telefon = value; }
        public List<string> JezykiProgramowania { get => jezykiProgramowania; set => jezykiProgramowania = value; }
    }
}
