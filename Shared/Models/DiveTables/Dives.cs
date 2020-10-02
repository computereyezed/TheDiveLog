using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models.DiveTables
{
    public class Dives
    {
        public long Id { get; set; }
        public System.Guid UserID { get; set; }
        public long DiveLocationID { get; set; }
        public System.DateTime DiveEnteredAt { get; set; }
        public int Depth { get; set; }
        public int BottomTime { get; set; }
        public System.DateTime DiveDateTime { get; set; }
        public int WaterEntryID { get; set; }
        public int WaterTypeID { get; set; }
        public string CertificationNo { get; set; }
        public int SignatureTypeID { get; set; }
        public string VerificationSignature { get; set; }
        public Nullable<int> AirTemperature { get; set; }
        public Nullable<int> BreathingID { get; set; }
        public string Comments { get; set; }
        public string EndPressureGroup { get; set; }
        public string ExposureProtectionHHFID { get; set; }
        public Nullable<int> ExposureProtectionID { get; set; }
        public Nullable<int> ExposureProtectionMM { get; set; }
        public string NewPressureGroup { get; set; }
        public Nullable<int> ResidualNitrogen { get; set; }
        public Nullable<bool> SpecialtyDive { get; set; }
        public Nullable<int> SpecialtyTypeID { get; set; }
        public string StartPressureGroup { get; set; }
        public Nullable<int> SurfaceInterval { get; set; }
        public Nullable<int> TankPressureEnd { get; set; }
        public Nullable<int> TankPressureStart { get; set; }
        public Nullable<int> WaterConditionID { get; set; }
        public Nullable<int> WaterSurfaceTemperature { get; set; }
        public Nullable<int> WaterBottomTemperature { get; set; }
        public Nullable<int> WaterVisibility { get; set; }
        public Nullable<int> WeatherID { get; set; }
        public Nullable<int> Weight { get; set; }
    }
}
