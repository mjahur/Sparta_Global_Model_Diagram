using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Contact
    {
        private string email;
        private string mobile;
        private string telephone;
        private Address address;

        public string Email { get => email; set => email = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public Address Address { get => address; set => address = value; }
    }
}