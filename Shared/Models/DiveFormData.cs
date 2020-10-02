using System;
using System.Collections.Generic;
using System.Text;
using TheDiveLog.Shared.Models.DiveTables;

namespace TheDiveLog.Shared.Models
{
    public class DiveFormData
    {
        public Dives Dive { get; set; }
        public DiveGraphic DG { get; set; }
        public List<DiveDropdownData> DDD { get; set; }
        public List<ViewLocation> Viewlocations { get; set; }
    }
}
