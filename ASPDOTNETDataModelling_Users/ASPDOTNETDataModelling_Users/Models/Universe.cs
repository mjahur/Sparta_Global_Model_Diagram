using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Universe
    {
        private string universeName;
        private int universeID;

        public string UniverseName { get => universeName; set => universeName = value; }
        public int UniverseID { get => universeID; set => universeID = value; }
    }
}