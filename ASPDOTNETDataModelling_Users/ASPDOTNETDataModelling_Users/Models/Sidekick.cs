using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Sidekick : Description
    {
       private int sidekickID;

        public int SidekickID { get => sidekickID; set => sidekickID = value; }
    }
}