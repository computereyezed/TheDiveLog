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
    public class DiverController : ControllerBase
    {
        private readonly DiveCtx _divectx;

        public DiverController(DiveCtx context)
        {
            this._divectx = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var diverinfo = await _divectx.DiverInformation.ToListAsync();
            return Ok(diverinfo);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(long id)
        //{
        //    return Ok(DiverInformation);
        //}

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
