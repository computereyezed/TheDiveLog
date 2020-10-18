using System;
using System.Collections.Generic;
using System.Text;
using TheDiveLog.Shared.Models.DiverTables;

namespace TheDiveLog.Shared.Models
{
    public class DiverView
    {
        public DiverInformation Diver { get; set; }

        public List<CertView> Certs { get; set; }

        public class CertView
        {
            public long Id { get; set; }
            public System.Guid UserID { get; set; }
            public Nullable<int> CertificationID { get; set; }
            public string Certification { get; set; }
            public Nullable<System.DateTime> CertDate { get; set; }
            public string InstrNo { get; set; }
            public string InstrName { get; set; }
            public string Location { get; set; }
            public Nullable<int> CountryCode { get; set; }
            public string Country { get; set; }
            public Nullable<long> Phone { get; set; }
        }
    }
}
