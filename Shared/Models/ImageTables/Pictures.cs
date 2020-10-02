using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models.ImageTables
{
    public class Pictures
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Nullable<long> Size { get; set; }
        public string Type { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<long> LocationId { get; set; }
        public byte[] Image { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public bool Active { get; set; }
    }
}
