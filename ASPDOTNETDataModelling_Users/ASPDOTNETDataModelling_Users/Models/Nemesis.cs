using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Nemesis : Description
    {
        private string reasonForEnemity;
        private LogIn NemesisID;

        public string ReasonForEnemity { get => reasonForEnemity; set => reasonForEnemity = value; }
        public LogIn NemesisID1 { get => NemesisID; set => NemesisID = value; }
    }
}