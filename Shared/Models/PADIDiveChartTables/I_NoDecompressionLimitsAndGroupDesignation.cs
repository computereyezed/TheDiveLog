using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models.PADIDiveChartTables
{
    public class I_NoDecompressionLimitsAndGroupDesignation
    {
        public int Id { get; set; }
        public Nullable<int> Depth { get; set; }
        public Nullable<int> Time { get; set; }
        public string PressureGroup { get; set; }
        public bool SafetyStopReq { get; set; }
        public bool NoDecompresstionLimit { get; set; }
    }
}
