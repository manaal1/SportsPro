using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsPro
{
    public class Incident
    {
        public int IncidentID { get; set; }
        public int CustomerID { get; set; }
        public string ProductCode { get; set; }
        public int TechID { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResolutionNotes { get; set; }

        public string CustomerIncidentDisplay()
        {
            string displayIncident = "Incident for product " + ProductCode + " closed " 
                + DateClosed.ToShortDateString() + " ( " + Title + " )";

            return displayIncident;
        }
    }
}