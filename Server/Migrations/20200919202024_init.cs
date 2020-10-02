using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheDiveLog.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(nullable: false),
                    CertificationID = table.Column<int>(nullable: true),
                    CertDate = table.Column<DateTime>(nullable: true),
                    InstrNo = table.Column<string>(nullable: true),
                    InstrName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    CountryCode = table.Column<int>(nullable: true),
                    Phone = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DDD",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DDD", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiverInformation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(nullable: false),
                    DiverNo = table.Column<string>(nullable: true),
                    DiverName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: true),
                    MeasurementID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiverInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dives",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(nullable: false),
                    DiveLocationID = table.Column<long>(nullable: false),
                    DiveEnteredAt = table.Column<DateTime>(nullable: false),
                    Depth = table.Column<int>(nullable: false),
                    BottomTime = table.Column<int>(nullable: false),
                    DiveDateTime = table.Column<DateTime>(nullable: false),
                    WaterEntryID = table.Column<int>(nullable: false),
                    WaterTypeID = table.Column<int>(nullable: false),
                    CertificationNo = table.Column<string>(nullable: true),
                    SignatureTypeID = table.Column<int>(nullable: false),
                    VerificationSignature = table.Column<string>(nullable: true),
                    AirTemperature = table.Column<int>(nullable: true),
                    BreathingID = table.Column<int>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    EndPressureGroup = table.Column<string>(nullable: true),
                    ExposureProtectionHHFID = table.Column<string>(nullable: true),
                    ExposureProtectionID = table.Column<int>(nullable: true),
                    ExposureProtectionMM = table.Column<int>(nullable: true),
                    NewPressureGroup = table.Column<string>(nullable: true),
                    ResidualNitrogen = table.Column<int>(nullable: true),
                    SpecialtyDive = table.Column<bool>(nullable: true),
                    SpecialtyTypeID = table.Column<int>(nullable: true),
                    StartPressureGroup = table.Column<string>(nullable: true),
                    SurfaceInterval = table.Column<int>(nullable: true),
                    TankPressureEnd = table.Column<int>(nullable: true),
                    TankPressureStart = table.Column<int>(nullable: true),
                    WaterConditionID = table.Column<int>(nullable: true),
                    WaterSurfaceTemperature = table.Column<int>(nullable: true),
                    WaterBottomTemperature = table.Column<int>(nullable: true),
                    WaterVisibility = table.Column<int>(nullable: true),
                    WeatherID = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_NoDecompressionLimitsAndGroupDesignation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Depth = table.Column<int>(nullable: true),
                    Time = table.Column<int>(nullable: true),
                    PressureGroup = table.Column<string>(nullable: true),
                    SafetyStopReq = table.Column<bool>(nullable: false),
                    NoDecompresstionLimit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_NoDecompressionLimitsAndGroupDesignation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "I_RepetitiveDiveTimetable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Column_0 = table.Column<string>(nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    Z = table.Column<int>(nullable: true),
                    Y = table.Column<int>(nullable: true),
                    X = table.Column<int>(nullable: true),
                    W = table.Column<int>(nullable: true),
                    V = table.Column<int>(nullable: true),
                    U = table.Column<int>(nullable: true),
                    T = table.Column<int>(nullable: true),
                    S = table.Column<int>(nullable: true),
                    R = table.Column<int>(nullable: true),
                    Q = table.Column<int>(nullable: true),
                    P = table.Column<int>(nullable: true),
                    O = table.Column<int>(nullable: true),
                    N = table.Column<int>(nullable: true),
                    M = table.Column<int>(nullable: true),
                    L = table.Column<int>(nullable: true),
                    K = table.Column<int>(nullable: true),
                    J = table.Column<int>(nullable: true),
                    I = table.Column<int>(nullable: true),
                    H = table.Column<int>(nullable: true),
                    G = table.Column<int>(nullable: true),
                    F = table.Column<int>(nullable: true),
                    E = table.Column<int>(nullable: true),
                    D = table.Column<int>(nullable: true),
                    C = table.Column<int>(nullable: true),
                    B = table.Column<int>(nullable: true),
                    A = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_I_RepetitiveDiveTimetable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<Guid>(nullable: false),
                    CountryID = table.Column<int>(nullable: true),
                    Located = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    WhatToSee = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_NoDecompressionLimitsAndGroupDesignation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Depth = table.Column<int>(nullable: true),
                    Time = table.Column<int>(nullable: true),
                    PressureGroup = table.Column<string>(nullable: true),
                    SafetyStopReq = table.Column<bool>(nullable: false),
                    NoDecompresstionLimit = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_NoDecompressionLimitsAndGroupDesignation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_RepetitiveDiveTimetable",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Column_0 = table.Column<string>(nullable: true),
                    Depth = table.Column<int>(nullable: true),
                    Z = table.Column<int>(nullable: true),
                    Y = table.Column<int>(nullable: true),
                    X = table.Column<int>(nullable: true),
                    W = table.Column<int>(nullable: true),
                    V = table.Column<int>(nullable: true),
                    U = table.Column<int>(nullable: true),
                    T = table.Column<int>(nullable: true),
                    S = table.Column<int>(nullable: true),
                    R = table.Column<int>(nullable: true),
                    Q = table.Column<int>(nullable: true),
                    P = table.Column<int>(nullable: true),
                    O = table.Column<int>(nullable: true),
                    N = table.Column<int>(nullable: true),
                    M = table.Column<int>(nullable: true),
                    L = table.Column<int>(nullable: true),
                    K = table.Column<int>(nullable: true),
                    J = table.Column<int>(nullable: true),
                    I = table.Column<int>(nullable: true),
                    H = table.Column<int>(nullable: true),
                    G = table.Column<int>(nullable: true),
                    F = table.Column<int>(nullable: true),
                    E = table.Column<int>(nullable: true),
                    D = table.Column<int>(nullable: true),
                    C = table.Column<int>(nullable: true),
                    B = table.Column<int>(nullable: true),
                    A = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_RepetitiveDiveTimetable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    LocationId = table.Column<long>(nullable: true),
                    Image = table.Column<byte[]>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurfaceIntervalCredit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingPressureGroup = table.Column<string>(nullable: true),
                    SurfaceInterval = table.Column<int>(nullable: true),
                    NewPressureGroup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurfaceIntervalCredit", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "DDD");

            migrationBuilder.DropTable(
                name: "DiverInformation");

            migrationBuilder.DropTable(
                name: "Dives");

            migrationBuilder.DropTable(
                name: "I_NoDecompressionLimitsAndGroupDesignation");

            migrationBuilder.DropTable(
                name: "I_RepetitiveDiveTimetable");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "M_NoDecompressionLimitsAndGroupDesignation");

            migrationBuilder.DropTable(
                name: "M_RepetitiveDiveTimetable");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "SurfaceIntervalCredit");
        }
    }
}

