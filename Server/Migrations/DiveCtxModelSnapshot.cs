using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheDiveLog.Server.Data;

namespace TheDiveLog.Server.Migrations
{
    [DbContext(typeof(DiveCtx))]
    partial class DiveCtxModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiveLogBook.Shared.Models.DiveInfo.DiveDropdownData", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("TypeId")
                    .HasColumnType("int");

                b.Property<int?>("Value")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("DDD");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.DiveInfo.Dives", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("AirTemperature")
                    .HasColumnType("int");

                b.Property<int>("BottomTime")
                    .HasColumnType("int");

                b.Property<int?>("BreathingID")
                    .HasColumnType("int");

                b.Property<string>("CertificationNo")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Comments")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Depth")
                    .HasColumnType("int");

                b.Property<DateTime>("DiveDateTime")
                    .HasColumnType("datetime2");

                b.Property<DateTime>("DiveEnteredAt")
                    .HasColumnType("datetime2");

                b.Property<long>("DiveLocationID")
                    .HasColumnType("bigint");

                b.Property<string>("EndPressureGroup")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("ExposureProtectionHHFID")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("ExposureProtectionID")
                    .HasColumnType("int");

                b.Property<int?>("ExposureProtectionMM")
                    .HasColumnType("int");

                b.Property<string>("NewPressureGroup")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("ResidualNitrogen")
                    .HasColumnType("int");

                b.Property<int>("SignatureTypeID")
                    .HasColumnType("int");

                b.Property<bool?>("SpecialtyDive")
                    .HasColumnType("bit");

                b.Property<int?>("SpecialtyTypeID")
                    .HasColumnType("int");

                b.Property<string>("StartPressureGroup")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("SurfaceInterval")
                    .HasColumnType("int");

                b.Property<int?>("TankPressureEnd")
                    .HasColumnType("int");

                b.Property<int?>("TankPressureStart")
                    .HasColumnType("int");

                b.Property<Guid>("UserID")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("VerificationSignature")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("WaterBottomTemperature")
                    .HasColumnType("int");

                b.Property<int?>("WaterConditionID")
                    .HasColumnType("int");

                b.Property<int>("WaterEntryID")
                    .HasColumnType("int");

                b.Property<int?>("WaterSurfaceTemperature")
                    .HasColumnType("int");

                b.Property<int>("WaterTypeID")
                    .HasColumnType("int");

                b.Property<int?>("WaterVisibility")
                    .HasColumnType("int");

                b.Property<int?>("WeatherID")
                    .HasColumnType("int");

                b.Property<int?>("Weight")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Dives");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.DiveSites.Countries", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Code")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Countries");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.DiveSites.Locations", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Comments")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("CountryID")
                    .HasColumnType("int");

                b.Property<double?>("Latitude")
                    .HasColumnType("float");

                b.Property<string>("Located")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Location")
                    .HasColumnType("nvarchar(max)");

                b.Property<double?>("Longitude")
                    .HasColumnType("float");

                b.Property<Guid>("UserID")
                    .HasColumnType("uniqueidentifier");

                b.Property<string>("WhatToSee")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Locations");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.DiverInfo.Certifications", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("CertDate")
                    .HasColumnType("datetime2");

                b.Property<int?>("CertificationID")
                    .HasColumnType("int");

                b.Property<int?>("CountryCode")
                    .HasColumnType("int");

                b.Property<string>("InstrName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("InstrNo")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Location")
                    .HasColumnType("nvarchar(max)");

                b.Property<long?>("Phone")
                    .HasColumnType("bigint");

                b.Property<Guid>("UserID")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("Certifications");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.DiverInfo.DiverInformation", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<DateTime?>("Birthday")
                    .HasColumnType("datetime2");

                b.Property<string>("DiverName")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("DiverNo")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("MeasurementID")
                    .HasColumnType("int");

                b.Property<Guid>("UserID")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("DiverInformation");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.Images.Pictures", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("bigint")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<bool>("Active")
                    .HasColumnType("bit");

                b.Property<DateTime?>("DateAdded")
                    .HasColumnType("datetime2");

                b.Property<byte[]>("Image")
                    .HasColumnType("varbinary(max)");

                b.Property<long?>("LocationId")
                    .HasColumnType("bigint");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<long?>("Size")
                    .HasColumnType("bigint");

                b.Property<string>("Type")
                    .HasColumnType("nvarchar(max)");

                b.Property<Guid?>("UserId")
                    .HasColumnType("uniqueidentifier");

                b.HasKey("Id");

                b.ToTable("Pictures");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.PADIDiveCharts.I_NoDecompressionLimitsAndGroupDesignation", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("Depth")
                    .HasColumnType("int");

                b.Property<bool>("NoDecompresstionLimit")
                    .HasColumnType("bit");

                b.Property<string>("PressureGroup")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("SafetyStopReq")
                    .HasColumnType("bit");

                b.Property<int?>("Time")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("I_NoDecompressionLimitsAndGroupDesignation");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.PADIDiveCharts.I_RepetitiveDiveTimetable", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("A")
                    .HasColumnType("int");

                b.Property<int?>("B")
                    .HasColumnType("int");

                b.Property<int?>("C")
                    .HasColumnType("int");

                b.Property<string>("Column_0")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("D")
                    .HasColumnType("int");

                b.Property<int?>("Depth")
                    .HasColumnType("int");

                b.Property<int?>("E")
                    .HasColumnType("int");

                b.Property<int?>("F")
                    .HasColumnType("int");

                b.Property<int?>("G")
                    .HasColumnType("int");

                b.Property<int?>("H")
                    .HasColumnType("int");

                b.Property<int?>("I")
                    .HasColumnType("int");

                b.Property<int?>("J")
                    .HasColumnType("int");

                b.Property<int?>("K")
                    .HasColumnType("int");

                b.Property<int?>("L")
                    .HasColumnType("int");

                b.Property<int?>("M")
                    .HasColumnType("int");

                b.Property<int?>("N")
                    .HasColumnType("int");

                b.Property<int?>("O")
                    .HasColumnType("int");

                b.Property<int?>("P")
                    .HasColumnType("int");

                b.Property<int?>("Q")
                    .HasColumnType("int");

                b.Property<int?>("R")
                    .HasColumnType("int");

                b.Property<int?>("S")
                    .HasColumnType("int");

                b.Property<int?>("T")
                    .HasColumnType("int");

                b.Property<int?>("U")
                    .HasColumnType("int");

                b.Property<int?>("V")
                    .HasColumnType("int");

                b.Property<int?>("W")
                    .HasColumnType("int");

                b.Property<int?>("X")
                    .HasColumnType("int");

                b.Property<int?>("Y")
                    .HasColumnType("int");

                b.Property<int?>("Z")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("I_RepetitiveDiveTimetable");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.PADIDiveCharts.M_NoDecompressionLimitsAndGroupDesignation", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("Depth")
                    .HasColumnType("int");

                b.Property<bool>("NoDecompresstionLimit")
                    .HasColumnType("bit");

                b.Property<string>("PressureGroup")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("SafetyStopReq")
                    .HasColumnType("bit");

                b.Property<int?>("Time")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("M_NoDecompressionLimitsAndGroupDesignation");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.PADIDiveCharts.M_RepetitiveDiveTimetable", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("A")
                    .HasColumnType("int");

                b.Property<int?>("B")
                    .HasColumnType("int");

                b.Property<int?>("C")
                    .HasColumnType("int");

                b.Property<string>("Column_0")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("D")
                    .HasColumnType("int");

                b.Property<int?>("Depth")
                    .HasColumnType("int");

                b.Property<int?>("E")
                    .HasColumnType("int");

                b.Property<int?>("F")
                    .HasColumnType("int");

                b.Property<int?>("G")
                    .HasColumnType("int");

                b.Property<int?>("H")
                    .HasColumnType("int");

                b.Property<int?>("I")
                    .HasColumnType("int");

                b.Property<int?>("J")
                    .HasColumnType("int");

                b.Property<int?>("K")
                    .HasColumnType("int");

                b.Property<int?>("L")
                    .HasColumnType("int");

                b.Property<int?>("M")
                    .HasColumnType("int");

                b.Property<int?>("N")
                    .HasColumnType("int");

                b.Property<int?>("O")
                    .HasColumnType("int");

                b.Property<int?>("P")
                    .HasColumnType("int");

                b.Property<int?>("Q")
                    .HasColumnType("int");

                b.Property<int?>("R")
                    .HasColumnType("int");

                b.Property<int?>("S")
                    .HasColumnType("int");

                b.Property<int?>("T")
                    .HasColumnType("int");

                b.Property<int?>("U")
                    .HasColumnType("int");

                b.Property<int?>("V")
                    .HasColumnType("int");

                b.Property<int?>("W")
                    .HasColumnType("int");

                b.Property<int?>("X")
                    .HasColumnType("int");

                b.Property<int?>("Y")
                    .HasColumnType("int");

                b.Property<int?>("Z")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("M_RepetitiveDiveTimetable");
            });

            modelBuilder.Entity("DiveLogBook.Shared.Models.PADIDiveCharts.SurfaceIntervalCredit", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("NewPressureGroup")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("StartingPressureGroup")
                    .HasColumnType("nvarchar(max)");

                b.Property<int?>("SurfaceInterval")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("SurfaceIntervalCredit");
            });
#pragma warning restore 612, 618
        }
    }
}
