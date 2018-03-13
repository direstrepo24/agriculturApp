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
  [ODataRoute("odata/agriculturebd/Equipos")]
  [Route("mvc/odata/agriculturebd/Equipos")]
  public partial class EquiposController : Controller
  {
    private Data.AgriculturebdContext context;

    public EquiposController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Equipos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Equipo> GetEquipos()
    {
      var items = this.context.Equipos.AsQueryable<Models.Agriculturebd.Equipo>();

      this.OnEquiposRead(ref items);

      return items;
    }

    partial void OnEquiposRead(ref IQueryable<Models.Agriculturebd.Equipo> items);

    [HttpGet("{Id}")]
    public IActionResult GetEquipo(Int64 key)
    {
        var item = this.context.Equipos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnEquipoDeleted(Models.Agriculturebd.Equipo item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteEquipo(Int64 key)
    {
        var item = this.context.Equipos
            .Where(i => i.Id == key)
            .Include(i => i.Receta)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnEquipoDeleted(item);
        this.context.Equipos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnEquipoUpdated(Models.Agriculturebd.Equipo item);

    [HttpPut("{Id}")]
    public IActionResult PutEquipo(Int64 key, [FromBody]Models.Agriculturebd.Equipo newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnEquipoUpdated(newItem);
        this.context.Equipos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchEquipo(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Equipos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnEquipoUpdated(item);
        this.context.Equipos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnEquipoCreated(Models.Agriculturebd.Equipo item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Equipo item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnEquipoCreated(item);
        this.context.Equipos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Equipos/{item.Id}", item);
    }
  }
}
