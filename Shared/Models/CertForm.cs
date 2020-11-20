using System;
using System.Collections.Generic;
using System.Text;
using TheDiveLog.Shared.Models.DiverTables;
using TheDiveLog.Shared.Models.DiveSiteTables;
using TheDiveLog.Shared.Models.DiveTables;

namespace TheDiveLog.Shared.Models
{
    public class CertForm
    {
        public Certifications Certification { get; set; }

        public List<Countries> ListCertCountries { get; set; }

        public List<DiveDropdownData> ListCertDDD { get; set; }

    }
}
