using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheDiveLog.Server.Data;
using TheDiveLog.Shared.Models;
using static TheDiveLog.Shared.Models.PictureView;

namespace TheDiveLog.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureController : ControllerBase
    {
        private readonly DiveCtx _divectx;

        public PictureController(DiveCtx context)
        {
            this._divectx = context;
        }

        [HttpGet()]
        public async Task<IActionResult> Get(int pgsize, int page)
        {
            PictureView pv = new PictureView();

            var query = await (from p in _divectx.Pictures
                               join l in _divectx.Locations on p.LocationId equals l.Id
                               join c in _divectx.Countries on l.CountryID equals c.Id
                               where (p.Active == true)
                               select new Picture
                               {
                                   Active = p.Active,
                                   DateAdded = p.DateAdded,
                                   Country = c.Country,
                                   Located = l.Located,
                                   Location = l.Location,
                                   Latitude = l.Latitude,
                                   Longitude = l.Longitude,
                                   WhatToSee = l.WhatToSee,
                                   Comments = l.Comments,
                                   Name = p.Name,
                                   PicturesId = p.Id,
                                   Size = p.Size,
                                   Type = p.Type,
                                   Image = p.Image,
                                   UserId = p.UserId
                               }).ToListAsync();

            pv.NumuberofPics = query.ToList().Count();
            var query1 = query.OrderByDescending(m => m.DateAdded);
            var query2 = query1.Skip(pgsize * page).Take(pgsize);
            pv.ListPics = new List<Picture>(query2);

            return Ok(pv);
        }


        //private string ConvertImage(byte[] image, string type)
        //{
        //    var img = Convert.ToBase64String(image.ToArray());
        //    return string.Format($"data:image/{type};base64,{img}");
        //}

        //public ActionResult ShowPicture(int? id)
        //{
        //    byte[] bytes = GetImage(id.Value, out string mime);
        //    return File(bytes, mime);
        //}

        //private byte[] GetImage(int picid, out string type)
        //{
        //    byte[] fileBytes = null;
        //    string fileType = null;
        //    var picture = _divectx.Pictures.FirstOrDefault(p => p.Id == picid);
        //    if (picture != null)
        //    {
        //        fileBytes = picture.Image;
        //        fileType = picture.Type;
        //    }
        //    type = fileType;
        //    return fileBytes;
        //}
    }
}
