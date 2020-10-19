using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheDiveLog.Server.Data;
using TheDiveLog.Shared.Models;
using TheDiveLog.Shared.Models.DiverTables;
using static TheDiveLog.Shared.Models.DiverView;

namespace TheDiveLog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiverController : ControllerBase
    {
        private readonly DiveCtx _divectx;

        public DiverController(DiveCtx context)
        {
            this._divectx = context;
        }

        [HttpGet("byUserId")]
        public async Task<IActionResult> Get(string userid)
        {
            DiverView diverview = new DiverView
            {
                Certs = await (from c in _divectx.Certifications
                               join dl in _divectx.DDD on c.CertificationID equals dl.Id
                               join cc in _divectx.Countries on c.CountryCode equals cc.Id
                               where c.UserID == new Guid(userid)
                               orderby c.CertDate descending
                               select new CertView
                               {
                                   Id = c.Id,
                                   UserID = c.UserID,
                                   CertificationID = dl.Id,
                                   Certification = dl.Name,
                                   CertDate = c.CertDate,
                                   InstrName = c.InstrName,
                                   InstrNo = c.InstrNo,
                                   CountryCode = c.CountryCode,
                                   Country = cc.Country,
                                   Location = c.Location,
                                   Phone = c.Phone
                               }).ToListAsync(),

                Diver = await _divectx.DiverInformation.FirstOrDefaultAsync(a => a.UserID == new Guid(userid))
            };

            if (diverview.Certs.Count < 1)
            {
                diverview.Certs = new List<CertView>();
            }

            return Ok(diverview);
        }

        [HttpGet("byCertId")]
        public async Task<IActionResult> Get(long certid)
        {
            Certifications cert = await _divectx.Certifications.FirstOrDefaultAsync(a => a.Id == certid);
            return Ok(cert);
        }

        public async Task<IActionResult> Post(DiverInformation dvr)
        {
            _divectx.Add(dvr);
            await _divectx.SaveChangesAsync();
            return Ok(dvr.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(DiverInformation dvr)
        {
            _divectx.Entry(dvr).State = EntityState.Modified;
            await _divectx.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var div = new DiverInformation { Id = id };
            _divectx.Remove(div);
            await _divectx.SaveChangesAsync();
            return NoContent();
        }
    }
}
