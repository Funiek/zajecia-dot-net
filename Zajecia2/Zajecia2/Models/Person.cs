using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Zajecia2.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private bool drivingLicence;

        [Display(Name ="Imię")]
        [Required(ErrorMessage = "pole 'Imię' jest obowiązkowe")]
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public bool DrivingLicence { get => drivingLicence; set => drivingLicence = value; }
    }
}
