using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheDiveLog.Shared.Models.DiverTables;
using TheDiveLog.Shared.Models.DiveSiteTables;
using TheDiveLog.Shared.Models.DiveTables;
using TheDiveLog.Shared.Models.ImageTables;
using TheDiveLog.Shared.Models.PADIDiveChartTables;

namespace TheDiveLog.Server.Data
{
    public class DiveCtx : DbContext
    {
        public DiveCtx(DbContextOptions<DiveCtx> options) : base(options)
        {
        }

        //Divelog
        public DbSet<Dives> Dives { get; set; }
        public DbSet<DiveDropdownData> DDD { get; set; }

        // DiverInfo
        public DbSet<DiverInformation> DiverInformation { get; set; }
        public DbSet<Certifications> Certifications { get; set; }

        //Dive Locations
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Countries> Countries { get; set; }

        //Images
        public DbSet<Pictures> Pictures { get; set; }

        //PADIDiveCharts
        public DbSet<I_NoDecompressionLimitsAndGroupDesignation> I_NoDecompressionLimitsAndGroupDesignation { get; set; }
        public DbSet<I_RepetitiveDiveTimetable> I_RepetitiveDiveTimetable { get; set; }
        public DbSet<M_NoDecompressionLimitsAndGroupDesignation> M_NoDecompressionLimitsAndGroupDesignation { get; set; }
        public DbSet<M_RepetitiveDiveTimetable> M_RepetitiveDiveTimetable { get; set; }
        public DbSet<SurfaceIntervalCredit> SurfaceIntervalCredit { get; set; }
    }
}
