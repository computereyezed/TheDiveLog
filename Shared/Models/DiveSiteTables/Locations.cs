using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models.DiveSiteTables
{
    public class Locations
    {
        public long Id { get; set; }
        public System.Guid UserID { get; set; }
        public Nullable<int> CountryID { get; set; }
        public string Located { get; set; }
        public string Location { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string WhatToSee { get; set; }
        public string Comments { get; set; }
    }
}
