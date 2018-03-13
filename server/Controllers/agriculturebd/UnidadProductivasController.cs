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
  [ODataRoute("odata/agriculturebd/UnidadProductivas")]
  [Route("mvc/odata/agriculturebd/UnidadProductivas")]
  public partial class UnidadProductivasController : Controller
  {
    private Data.AgriculturebdContext context;

    public UnidadProductivasController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/UnidadProductivas
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.UnidadProductiva> GetUnidadProductivas()
    {
      var items = this.context.UnidadProductivas.AsQueryable<Models.Agriculturebd.UnidadProductiva>();

      this.OnUnidadProductivasRead(ref items);

      return items;
    }

    partial void OnUnidadProductivasRead(ref IQueryable<Models.Agriculturebd.UnidadProductiva> items);

    [HttpGet("{Id}")]
    public IActionResult GetUnidadProductiva(Int64 key)
    {
        var item = this.context.UnidadProductivas.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnUnidadProductivaDeleted(Models.Agriculturebd.UnidadProductiva item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteUnidadProductiva(Int64 key)
    {
        var item = this.context.UnidadProductivas
            .Where(i => i.Id == key)
            .Include(i => i.LocalizacionUps)
            .Include(i => i.Lotes)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnUnidadProductivaDeleted(item);
        this.context.UnidadProductivas.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnUnidadProductivaUpdated(Models.Agriculturebd.UnidadProductiva item);

    [HttpPut("{Id}")]
    public IActionResult PutUnidadProductiva(Int64 key, [FromBody]Models.Agriculturebd.UnidadProductiva newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnUnidadProductivaUpdated(newItem);
        this.context.UnidadProductivas.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchUnidadProductiva(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.UnidadProductivas.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnUnidadProductivaUpdated(item);
        this.context.UnidadProductivas.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnUnidadProductivaCreated(Models.Agriculturebd.UnidadProductiva item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.UnidadProductiva item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnUnidadProductivaCreated(item);
        this.context.UnidadProductivas.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/UnidadProductivas/{item.Id}", item);
    }
  }
}
