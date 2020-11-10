using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheDiveLog.Server.Data;
using TheDiveLog.Shared.Models.DiverTables;

namespace TheDiveLog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertController : ControllerBase
    {
        private readonly DiveCtx _divectx;

        public CertController(DiveCtx context)
        {
            this._divectx = context;
        }

        [HttpGet("byCertId")]
        public async Task<IActionResult> Get(long certid)
        {
            Certifications cert = await _divectx.Certifications.FirstOrDefaultAsync(a => a.Id == certid);
            return Ok(cert);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Certifications cert)
        {
            _divectx.Add(cert);
            await _divectx.SaveChangesAsync();
            return Ok(cert.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Certifications cert)
        {
            _divectx.Entry(cert).State = EntityState.Modified;
            await _divectx.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var cert = new Certifications { Id = id };
            _divectx.Remove(cert);
            await _divectx.SaveChangesAsync();
            return NoContent();
        }
    }
}
