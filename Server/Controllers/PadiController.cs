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
                ListNDLPGD = new List<Usp_PADINDLPGD_Result>(),
                Result = new Usp_PADINDLPGD_Result()
            };

            using var conn = new SqlConnection("Data Source=BJS-SURFACE;Initial Catalog=DiveLogBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            {
                using var command = new SqlCommand("dbo.usp_PADINDLPGD", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        diveChartView.Result = new Usp_PADINDLPGD_Result()
                        {
                            PressureGroup = (string)reader.GetValue(0),
                            C35 = GetInt(reader, 1),
                            C40 = GetInt(reader, 2),
                            C50 = GetInt(reader, 3),
                            C60 = GetInt(reader, 4),
                            C70 = GetInt(reader, 5),
                            C80 = GetInt(reader, 6),
                            C90 = GetInt(reader, 7),
                            C100 = GetInt(reader, 8),
                            C110 = GetInt(reader, 9),
                            C120 = GetInt(reader, 10),
                            C130 = GetInt(reader, 11),
                            C140 = GetInt(reader, 12),
                        };
                        diveChartView.ListNDLPGD.Add(diveChartView.Result);
                    }
                }
            };

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