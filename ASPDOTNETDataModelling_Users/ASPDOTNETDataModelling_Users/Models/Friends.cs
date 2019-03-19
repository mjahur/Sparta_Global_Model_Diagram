using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Friends
    {
        private List<string> friendlist;
        private int friendlistID;

        public List<string> Friendlist { get => friendlist; set => friendlist = value; }
        public int FriendlistID { get => friendlistID; set => friendlistID = value; }
    }
}