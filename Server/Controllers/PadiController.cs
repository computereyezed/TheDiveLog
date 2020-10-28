using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http.Description;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TheDiveLog.Server.Data;
using TheDiveLog.Shared.Models;
using TheDiveLog.Shared.Models.PADIDiveChartTables;
using static TheDiveLog.Shared.Models.DiveChartView;

namespace TheDiveLog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PadiController : ControllerBase
    {
        private readonly DiveCtx _divectx;

        public PadiController(DiveCtx context)
        {
            _divectx = context;
        }

        [HttpGet("byMeasurement")]
        public async Task<ActionResult<DiveChartView>> Get(int mesurementid)
        {
            DiveChartView diveChartView = new DiveChartView
            {
                ListNDLPGD = new List<NDLGD>(),
                NDLPG_Result = new NDLGD(),
                ListSIC = new List<SIC>(),
                SIC_Result = new SIC(),
                ListRDT = new List<RDT>(),
                RDT_Result = new RDT(),
                //IrdtList = new List<I_RepetitiveDiveTimetable>(),
                //MrdtList = new List<M_RepetitiveDiveTimetable>()
            };

            #region No Decompression Limits and Group Designation
            using var ndclconn = new SqlConnection("Data Source=BJS-SURFACE;Initial Catalog=DiveLogBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            {
                //NDCL
                using var cmdndcl = new SqlCommand("dbo.usp_PADINDLPGD", ndclconn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                ndclconn.Open();
                SqlDataReader ndclreader = await cmdndcl.ExecuteReaderAsync();

                if (ndclreader.HasRows)
                {
                    while (ndclreader.Read())
                    {
                        diveChartView.NDLPG_Result = new NDLGD
                        {
                            PressureGroup = (string)ndclreader.GetValue(0),
                            C35 = GetInt(ndclreader, 1),
                            C40 = GetInt(ndclreader, 2),
                            C50 = GetInt(ndclreader, 3),
                            C60 = GetInt(ndclreader, 4),
                            C70 = GetInt(ndclreader, 5),
                            C80 = GetInt(ndclreader, 6),
                            C90 = GetInt(ndclreader, 7),
                            C100 = GetInt(ndclreader, 8),
                            C110 = GetInt(ndclreader, 9),
                            C120 = GetInt(ndclreader, 10),
                            C130 = GetInt(ndclreader, 11),
                            C140 = GetInt(ndclreader, 12),
                        };
                        diveChartView.ListNDLPGD.Add(diveChartView.NDLPG_Result);
                    }
                }
            }
            #endregion

            #region Surface Interval Credit Table (all times in minutes)
            using var sicconn = new SqlConnection("Data Source=BJS-SURFACE;Initial Catalog=DiveLogBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            {
                //SIC
                using var cmdsic = new SqlCommand("dbo.usp_PADISIC", sicconn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                //cmdsic.Parameters.AddWithValue("@Mesurement", mesurementid);

                sicconn.Open();
                SqlDataReader sicreader = await cmdsic.ExecuteReaderAsync();

                if (sicreader.HasRows)
                {
                    while (sicreader.Read())
                    {
                        diveChartView.SIC_Result = new SIC()
                        {
                            StartingPressureGroup = (string)sicreader.GetValue(0),
                            A = GetInt(sicreader, 1),
                            B = GetInt(sicreader, 2),
                            C = GetInt(sicreader, 3),
                            D = GetInt(sicreader, 4),
                            E = GetInt(sicreader, 5),
                            F = GetInt(sicreader, 6),
                            G = GetInt(sicreader, 7),
                            H = GetInt(sicreader, 8),
                            I = GetInt(sicreader, 9),
                            J = GetInt(sicreader, 10),
                            K = GetInt(sicreader, 11),
                            L = GetInt(sicreader, 12),
                            M = GetInt(sicreader, 13),
                            N = GetInt(sicreader, 14),
                            O = GetInt(sicreader, 15),
                            P = GetInt(sicreader, 16),
                            Q = GetInt(sicreader, 17),
                            R = GetInt(sicreader, 18),
                            S = GetInt(sicreader, 19),
                            T = GetInt(sicreader, 20),
                            U = GetInt(sicreader, 21),
                            V = GetInt(sicreader, 22),
                            W = GetInt(sicreader, 23),
                            X = GetInt(sicreader, 24),
                            Y = GetInt(sicreader, 25),
                            Z = GetInt(sicreader, 26),
                        };
                        diveChartView.ListSIC.Add(diveChartView.SIC_Result);
                    }
                }
            };
            #endregion

            #region RepetitiveDiveTimetable

            if (mesurementid == 35)
            {
                List<I_RepetitiveDiveTimetable> iresult = new List<I_RepetitiveDiveTimetable>();

                iresult = await _divectx.I_RepetitiveDiveTimetable.ToListAsync();

                foreach (var item in iresult)
                {
                    RDT rdt = new RDT
                    {
                        ID = item.Id,
                        Column_0 = item.Column_0,
                        Depth = item.Depth,
                        Z = item.Z,
                        Y = item.Y,
                        X = item.X,
                        W = item.W,
                        V = item.V,
                        U = item.U,
                        T = item.T,
                        S = item.S,
                        R = item.R,
                        Q = item.Q,
                        P = item.P,
                        O = item.O,
                        N = item.N,
                        M = item.M,
                        L = item.L,
                        K = item.K,
                        J = item.J,
                        I = item.I,
                        H = item.H,
                        G = item.G,
                        F = item.F,
                        E = item.E,
                        D = item.D,
                        C = item.C,
                        B = item.B,
                        A = item.A,
                    };
                    diveChartView.ListRDT.Add(rdt);
                }
            }
            else
            {
                List<M_RepetitiveDiveTimetable> mresult = new List<M_RepetitiveDiveTimetable>();

                mresult = await _divectx.M_RepetitiveDiveTimetable.ToListAsync();

                foreach (var item in mresult)
                {
                    RDT rdt = new RDT
                    {
                        ID = item.Id,
                        Column_0 = item.Column_0,
                        Depth = item.Depth,
                        Z = item.Z,
                        Y = item.Y,
                        X = item.X,
                        W = item.W,
                        V = item.V,
                        U = item.U,
                        T = item.T,
                        S = item.S,
                        R = item.R,
                        Q = item.Q,
                        P = item.P,
                        O = item.O,
                        N = item.N,
                        M = item.M,
                        L = item.L,
                        K = item.K,
                        J = item.J,
                        I = item.I,
                        H = item.H,
                        G = item.G,
                        F = item.F,
                        E = item.E,
                        D = item.D,
                        C = item.C,
                        B = item.B,
                        A = item.A,
                    };
                    diveChartView.ListRDT.Add(rdt);
                }
            }
            #endregion

            return Ok(diveChartView);
        }

        private int? GetInt(SqlDataReader reader, int colIndex)
        {
            int? value;

            if (!reader.IsDBNull(colIndex))
            {
                value = (int?)reader.GetValue(colIndex);
            }
            else
            {
                value = null;
            }

            return value;
        }
    }
}