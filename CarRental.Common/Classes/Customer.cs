using CarRental.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Common.Classes
{
    public class Customer : IPerson
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int SocialSecurityNumber { get; set; }

        public Customer(string firstName, string lastName, int socialSecurityNumber)
        {
            (FirstName, LastName, SocialSecurityNumber) = (firstName, lastName, socialSecurityNumber);
        }

        public int GetSocialSecurityNumber() => SocialSecurityNumber;
        public string GetFullName() => $"{FirstName} {LastName}";
    }
}
