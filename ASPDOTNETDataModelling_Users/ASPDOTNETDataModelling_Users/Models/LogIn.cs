using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class LogIn
    {
        private int userID;
        private string password;
        private Address addressID;
        private AssociatedOrganisation aoID;
        private Contact contactID;
        private Description descriptionID;
        private Father fatherID;
        private Mother motherID;
        private Nemesis nemesisID;

        
        public string Password { get => password; set => password = value; }
        public int UserID { get => userID; set => userID = value; }
        public Address AddressID { get => addressID; set => addressID = value; }
        public AssociatedOrganisation AoID { get => aoID; set => aoID = value; }
        public Contact ContactID { get => contactID; set => contactID = value; }
        public Description DescriptionID { get => descriptionID; set => descriptionID = value; }
        public Father FatherID { get => fatherID; set => fatherID = value; }
        public Mother MotherID { get => motherID; set => motherID = value; }
        public Nemesis NemesisID { get => nemesisID; set => nemesisID = value; }
    }
}