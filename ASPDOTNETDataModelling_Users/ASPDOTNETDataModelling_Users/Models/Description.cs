using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPDOTNETDataModelling_Users.Models
{
    public class Description
    {
        private string name;
        private string hairColour;
        private string eyeColour;
        private string height;
        private string background;
        private string powers;
        private int descriptionID;
        private Universe universe;
        
        public string HairColour { get => hairColour; set => hairColour = value; }
        public string EyeColour { get => eyeColour; set => eyeColour = value; }
        public string Height { get => height; set => height = value; }
        public string Background { get => background; set => background = value; }
        public string Powers { get => powers; set => powers = value; }
        public int DescriptionID { get => descriptionID; set => descriptionID = value; }
        public string Name { get => name; set => name = value; }
    }
}