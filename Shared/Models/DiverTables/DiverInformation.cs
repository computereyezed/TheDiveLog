using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models.DiverTables
{
    public class DiverInformation
    {
        public long Id { get; set; }
        public System.Guid UserID { get; set; }
        public string DiverNo { get; set; }
        public string DiverName { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<int> MeasurementID { get; set; }
    }
}
