using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Security
    {
        private LogIn userID;
        private string question;
        private string answer;

        
        public string Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
        public LogIn UserID { get => userID; set => userID = value; }
    }
}