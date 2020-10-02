using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models
{
    public class ViewLocation
    {
        public long Id { get; set; }
        public string Located { get; set; }
        public string Location { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string WhatToSee { get; set; }
        public string Comments { get; set; }

        public string Code { get; set; }
        public string Country { get; set; }
        public int CountryId { get; set; }

    }
}
