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
  [ODataRoute("odata/agriculturebd/Enfermedades")]
  [Route("mvc/odata/agriculturebd/Enfermedades")]
  public partial class EnfermedadesController : Controller
  {
    private Data.AgriculturebdContext context;

    public EnfermedadesController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Enfermedades
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Enfermedade> GetEnfermedades()
    {
      var items = this.context.Enfermedades.AsQueryable<Models.Agriculturebd.Enfermedade>();

      this.OnEnfermedadesRead(ref items);

      return items;
    }

    partial void OnEnfermedadesRead(ref IQueryable<Models.Agriculturebd.Enfermedade> items);

    [HttpGet("{Id}")]
    public IActionResult GetEnfermedade(Int64 key)
    {
        var item = this.context.Enfermedades.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnEnfermedadeDeleted(Models.Agriculturebd.Enfermedade item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteEnfermedade(Int64 key)
    {
        var item = this.context.Enfermedades
            .Where(i => i.Id == key)
            .Include(i => i.Fotos)
            .Include(i => i.ControlPlagas)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnEnfermedadeDeleted(item);
        this.context.Enfermedades.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnEnfermedadeUpdated(Models.Agriculturebd.Enfermedade item);

    [HttpPut("{Id}")]
    public IActionResult PutEnfermedade(Int64 key, [FromBody]Models.Agriculturebd.Enfermedade newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnEnfermedadeUpdated(newItem);
        this.context.Enfermedades.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchEnfermedade(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Enfermedades.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnEnfermedadeUpdated(item);
        this.context.Enfermedades.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnEnfermedadeCreated(Models.Agriculturebd.Enfermedade item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Enfermedade item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnEnfermedadeCreated(item);
        this.context.Enfermedades.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Enfermedades/{item.Id}", item);
    }
  }
}
