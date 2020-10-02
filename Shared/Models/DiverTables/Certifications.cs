using System;
using System.Collections.Generic;
using System.Text;

namespace TheDiveLog.Shared.Models.DiverTables
{
    public class Certifications
    {
        public long Id { get; set; }
        public System.Guid UserID { get; set; }
        public Nullable<int> CertificationID { get; set; }
        public Nullable<System.DateTime> CertDate { get; set; }
        public string InstrNo { get; set; }
        public string InstrName { get; set; }
        public string Location { get; set; }
        public Nullable<int> CountryCode { get; set; }
        public Nullable<long> Phone { get; set; }
    }
}
