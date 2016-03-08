using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehandelsite.ViewModels
{
    public class Address
    {
        public Address(string street, string city, int zip, string country)
        {
            Street = street;
            City = city;
            Zip = zip;
            Country = country;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Country { get; set; }
    }
}
