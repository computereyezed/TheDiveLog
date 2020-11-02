using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheDiveLog.Server.Data;
using TheDiveLog.Shared.Models;
using TheDiveLog.Shared.Models.DiveTables;

namespace TheDiveLog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiveController : ControllerBase
    {
        private readonly DiveCtx _divectx;

        public List<DiveView> ListDV { get; private set; }

        public DiveController(DiveCtx context)
        {
            this._divectx = context;
        }

        [HttpGet("All")]
        public IActionResult Get()
        {
            ListDV = (List<DiveView>)(from d in _divectx.Dives
                                      join dl in _divectx.Locations on d.DiveLocationID equals dl.Id
                                      join c in _divectx.Countries on dl.CountryID equals c.Id
                                      //where d.UserID == userid
                                      orderby d.DiveDateTime descending
                                      select new DiveView
                                      {
                                          DiveLogId = d.Id,
                                          DiverId = d.UserID,
                                          DiveLocationId = d.DiveLocationID,
                                          DiveDateTime = d.DiveDateTime,
                                          Depth = d.Depth,
                                          BottomTime = d.BottomTime,
                                          Country = c.Country,
                                          Located = dl.Located,
                                          Location = dl.Location,
                                          Latitude = dl.Latitude,
                                          Longitude = dl.Longitude,
                                          WhatToSee = dl.WhatToSee,
                                          Comments = dl.Comments
                                      }).ToList();
            return Ok(ListDV);
        }

        [HttpGet("byUserId")]
        public async Task<IActionResult> Get(string userid)
        {
            ListDV = (List<DiveView>) await (from d in _divectx.Dives
                                      join dl in _divectx.Locations on d.DiveLocationID equals dl.Id
                                      join c in _divectx.Countries on dl.CountryID equals c.Id
                                      where d.UserID == new Guid(userid)
                                      orderby d.DiveDateTime descending
                                      select new DiveView
                                      {
                                          DiveLogId = d.Id,
                                          DiverId = d.UserID,
                                          DiveLocationId = d.DiveLocationID,
                                          DiveDateTime = d.DiveDateTime,
                                          Depth = d.Depth,
                                          BottomTime = d.BottomTime,
                                          Country = c.Country,
                                          Located = dl.Located,
                                          Location = dl.Location,
                                          Latitude = dl.Latitude,
                                          Longitude = dl.Longitude,
                                          WhatToSee = dl.WhatToSee,
                                          Comments = dl.Comments
                                      }).ToListAsync();
            return Ok(ListDV);
        }

        [HttpGet("byId")]
        public async Task<IActionResult> Get(long id)
        {
            DiveFormData diveFormData = new DiveFormData
            {
                AllLocs = await _divectx.Locations.ToListAsync(),
                Dive = await _divectx.Dives.FirstOrDefaultAsync(a => a.Id == id),
                DDD = await _divectx.DDD.ToListAsync(),
                Viewlocations = (List<ViewLocation>)(from l in _divectx.Locations
                                                     join c in _divectx.Countries on l.CountryID equals c.Id
                                                     orderby c.Country descending
                                                     select new ViewLocation
                                                     {
                                                         Id = l.Id,
                                                         Located = l.Located,
                                                         Location = l.Location,
                                                         Latitude = l.Latitude,
                                                         Longitude = l.Longitude,
                                                         WhatToSee = l.WhatToSee,
                                                         Comments = l.Comments,
                                                         Code = c.Code,
                                                         Country = c.Country,
                                                         CountryId = c.Id
                                                     }).ToList()
            };

            return Ok(diveFormData);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Dives dive)
        {
            _divectx.Add(dive);
            await _divectx.SaveChangesAsync();
            return Ok(dive.Id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Dives dive)
        {
            _divectx.Entry(dive).State = EntityState.Modified;
            await _divectx.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            var div = new Dives { Id = id };
            _divectx.Remove(div);
            await _divectx.SaveChangesAsync();
            return NoContent();
        }

        public Guid GetUserId(string email)
        {
            Guid userid = _divectx.DiverInformation.Where(w => w.Email == email).Select(s => s.UserID).FirstOrDefault();
            return (userid);
        }
    }
}
