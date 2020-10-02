using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models
{
    public class DiveView
    {
        public long DiveLogId { get; set; }
        public Guid DiverId { get; set; }
        public long DiveLocationId { get; set; }
        public DateTime DiveDateTime { get; set; }
        public int Depth { get; set; }
        public int BottomTime { get; set; }
        public string Country { get; set; }
        public string Located { get; set; }
        public string Location { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string WhatToSee { get; set; }
        public string Comments { get; set; }
    }

    
}
