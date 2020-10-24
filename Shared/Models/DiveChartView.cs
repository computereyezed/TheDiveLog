using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace TheDiveLog.Shared.Models
{
    public class DiveChartView
    {
        public List<Usp_PADINDLPGD_Result> ListNDLPGD { get; set; }
        public Usp_PADINDLPGD_Result Result { get; set; }

    public class Usp_PADINDLPGD_Result
        {
            public string PressureGroup { get; set; }
            public Nullable<int> C35 { get; set; }
            public Nullable<int> C40 { get; set; }
            public Nullable<int> C50 { get; set; }
            public Nullable<int> C60 { get; set; }
            public Nullable<int> C70 { get; set; }
            public Nullable<int> C80 { get; set; }
            public Nullable<int> C90 { get; set; }
            public Nullable<int> C100 { get; set; }
            public Nullable<int> C110 { get; set; }
            public Nullable<int> C120 { get; set; }
            public Nullable<int> C130 { get; set; }
            public Nullable<int> C140 { get; set; }
        }
    }
}
