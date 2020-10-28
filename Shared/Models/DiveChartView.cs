using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using TheDiveLog.Shared.Models.PADIDiveChartTables;
namespace TheDiveLog.Shared.Models
{
    public class DiveChartView
    {
        #region No Decompression Limits and Group Designation
        public List<NDLGD> ListNDLPGD { get; set; }
        public NDLGD NDLPG_Result { get; set; }
        public class NDLGD
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
        #endregion

        #region Surface Interval Credit Table (all times in minutes)
        public List<SIC> ListSIC { get; set; }
        public SIC SIC_Result { get; set; }
        public class SIC
        {
            public string StartingPressureGroup { get; set; }
            public Nullable<int> A { get; set; }
            public Nullable<int> B { get; set; }
            public Nullable<int> C { get; set; }
            public Nullable<int> D { get; set; }
            public Nullable<int> E { get; set; }
            public Nullable<int> F { get; set; }
            public Nullable<int> G { get; set; }
            public Nullable<int> H { get; set; }
            public Nullable<int> I { get; set; }
            public Nullable<int> J { get; set; }
            public Nullable<int> K { get; set; }
            public Nullable<int> L { get; set; }
            public Nullable<int> M { get; set; }
            public Nullable<int> N { get; set; }
            public Nullable<int> O { get; set; }
            public Nullable<int> P { get; set; }
            public Nullable<int> Q { get; set; }
            public Nullable<int> R { get; set; }
            public Nullable<int> S { get; set; }
            public Nullable<int> T { get; set; }
            public Nullable<int> U { get; set; }
            public Nullable<int> V { get; set; }
            public Nullable<int> W { get; set; }
            public Nullable<int> X { get; set; }
            public Nullable<int> Y { get; set; }
            public Nullable<int> Z { get; set; }
        }
        #endregion

        #region RepetitiveDiveTimetable
        public List<RDT> ListRDT { get; set; }
        public RDT RDT_Result { get; set; }
        public class RDT
        {
            public int ID { get; set; }
            public string Column_0 { get; set; }
            public Nullable<int> Depth { get; set; }
            public Nullable<int> Z { get; set; }
            public Nullable<int> Y { get; set; }
            public Nullable<int> X { get; set; }
            public Nullable<int> W { get; set; }
            public Nullable<int> V { get; set; }
            public Nullable<int> U { get; set; }
            public Nullable<int> T { get; set; }
            public Nullable<int> S { get; set; }
            public Nullable<int> R { get; set; }
            public Nullable<int> Q { get; set; }
            public Nullable<int> P { get; set; }
            public Nullable<int> O { get; set; }
            public Nullable<int> N { get; set; }
            public Nullable<int> M { get; set; }
            public Nullable<int> L { get; set; }
            public Nullable<int> K { get; set; }
            public Nullable<int> J { get; set; }
            public Nullable<int> I { get; set; }
            public Nullable<int> H { get; set; }
            public Nullable<int> G { get; set; }
            public Nullable<int> F { get; set; }
            public Nullable<int> E { get; set; }
            public Nullable<int> D { get; set; }
            public Nullable<int> C { get; set; }
            public Nullable<int> B { get; set; }
            public Nullable<int> A { get; set; }
        }
        #endregion
    }
}
