using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Father : Description
    {
        private int fatherID;

        public int FatherID { get => fatherID; set => fatherID = value; }
    }
}