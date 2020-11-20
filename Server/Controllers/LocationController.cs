using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheDiveLog.Server.Data;
using TheDiveLog.Shared.Models;
using TheDiveLog.Shared.Models.DiveSiteTables;

namespace TheDiveLog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly DiveCtx _divectx;

        public LocationController(DiveCtx context)
        {
            _divectx = context;
        }

        [HttpGet("byLocId")]
        public async Task<IActionResult> Get(long locid)
        {
            LocationForm locationForm = new LocationForm
            {
                Location = await _divectx.Locations.FirstOrDefaultAsync(a => a.Id == locid),
                ListLocCountries = _divectx.Countries.ToList(),
            };

            return Ok(locationForm);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Locations loc)
        {
            _divectx.Add(loc);
            await _divectx.SaveChangesAsync();
            return Ok(loc.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Locations loc)
        {
            _divectx.Entry(loc).State = EntityState.Modified;
            await _divectx.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var cert = new Locations { Id = id };
            _divectx.Remove(cert);
            await _divectx.SaveChangesAsync();
            return NoContent();
        }
    }
}
