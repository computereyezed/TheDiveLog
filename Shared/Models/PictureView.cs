using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TheDiveLog.Shared.Models.ImageTables;

namespace TheDiveLog.Shared.Models
{
    public class PictureView
    {
        public long NumuberofPics { get; set; }
        public List<Picture> ListPics { get; set; }

        public class Picture
        {
            public long PicturesId { get; set; }
            public string Name { get; set; }
            public Nullable<long> Size { get; set; }
            public Nullable<System.Guid> UserId { get; set; }
            public Nullable<System.DateTime> DateAdded { get; set; }
            public bool Active { get; set; }
            public string Country { get; set; }
            public string Located { get; set; }
            public string Location { get; set; }
            public double? Latitude { get; set; }
            public double? Longitude { get; set; }
            public string WhatToSee { get; set; }
            public string Comments { get; set; }
            public string Type { get; set; }
            public byte[] Image { get; set; }
            public string Imgscr { get; set; }
        }

    }
}
