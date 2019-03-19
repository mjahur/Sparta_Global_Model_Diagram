using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class AssociatedOrganisation
    {
        private string Name;
        private string GoodOrEvil;
        private string Purpose;
        private Universe universe;
        private int aoID;

        public string Name1 { get => Name; set => Name = value; }
        public string GoodOrEvil1 { get => GoodOrEvil; set => GoodOrEvil = value; }
        public string Purpose1 { get => Purpose; set => Purpose = value; }
        public Universe Universe { get => universe; set => universe = value; }
        public int AoID { get => aoID; set => aoID = value; }
    }
}