using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Groups
    {
        private AssociatedOrganisation Organisation;
        private string groupName;
        private List<string> members;
        private int groupID;

        public AssociatedOrganisation Organisation1 { get => Organisation; set => Organisation = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public List<string> Members { get => members; set => members = value; }
        public int GroupID { get => groupID; set => groupID = value; }
    }
}