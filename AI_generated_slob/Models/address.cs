using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Models
{
    public class Address
    {

        public string Country { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }
        public string Floor { get; set; }
        public string ApartmentNumber { get; set; }

        public Address(string country, string region, string postalCode, string city, string addressLine, string floor, string apartmentNumber)
        {
            Country = country;
            Region = region;
            PostalCode = postalCode;
            City = city;
            AddressLine = addressLine;
            Floor = floor;
            ApartmentNumber = apartmentNumber;
        }
    }
}
