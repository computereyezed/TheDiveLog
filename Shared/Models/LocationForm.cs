using System;
using System.Collections.Generic;
using System.Text;
using TheDiveLog.Shared.Models.DiveSiteTables;

namespace TheDiveLog.Shared.Models
{
    public class LocationForm
    {
        public Locations Location { get; set; }
        public List<Countries> ListLocCountries { get; set; }
    }
}
