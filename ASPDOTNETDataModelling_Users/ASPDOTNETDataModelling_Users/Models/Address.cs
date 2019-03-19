using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Address
    {
        private string line1;
        private string city;
        private string postcode;

        public string Line1 { get => line1; set => line1 = value; }
        public string City { get => city; set => city = value; }
        public string Postcode { get => postcode; set => postcode = value; }
    }
}