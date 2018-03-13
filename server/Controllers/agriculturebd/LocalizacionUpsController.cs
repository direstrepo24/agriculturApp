using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Agriculturapp.Controllers.Agriculturebd
{
  using Models;
  using Data;
  using Models.Agriculturebd;

  [EnableQuery]
  [ODataRoute("odata/agriculturebd/LocalizacionUps")]
  [Route("mvc/odata/agriculturebd/LocalizacionUps")]
  public partial class LocalizacionUpsController : Controller
  {
    private Data.AgriculturebdContext context;

    public LocalizacionUpsController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/LocalizacionUps
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.LocalizacionUp> GetLocalizacionUps()
    {
      var items = this.context.LocalizacionUps.AsQueryable<Models.Agriculturebd.LocalizacionUp>();

      this.OnLocalizacionUpsRead(ref items);

      return items;
    }

    partial void OnLocalizacionUpsRead(ref IQueryable<Models.Agriculturebd.LocalizacionUp> items);

    [HttpGet("{Id}")]
    public IActionResult GetLocalizacionUp(Int64 key)
    {
        var item = this.context.LocalizacionUps.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnLocalizacionUpDeleted(Models.Agriculturebd.LocalizacionUp item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteLocalizacionUp(Int64 key)
    {
        var item = this.context.LocalizacionUps
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnLocalizacionUpDeleted(item);
        this.context.LocalizacionUps.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnLocalizacionUpUpdated(Models.Agriculturebd.LocalizacionUp item);

    [HttpPut("{Id}")]
    public IActionResult PutLocalizacionUp(Int64 key, [FromBody]Models.Agriculturebd.LocalizacionUp newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnLocalizacionUpUpdated(newItem);
        this.context.LocalizacionUps.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchLocalizacionUp(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.LocalizacionUps.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnLocalizacionUpUpdated(item);
        this.context.LocalizacionUps.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnLocalizacionUpCreated(Models.Agriculturebd.LocalizacionUp item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.LocalizacionUp item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnLocalizacionUpCreated(item);
        this.context.LocalizacionUps.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/LocalizacionUps/{item.Id}", item);
    }
  }
}
