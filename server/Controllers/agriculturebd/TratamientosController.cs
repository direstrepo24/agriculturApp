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
  [ODataRoute("odata/agriculturebd/Tratamientos")]
  [Route("mvc/odata/agriculturebd/Tratamientos")]
  public partial class TratamientosController : Controller
  {
    private Data.AgriculturebdContext context;

    public TratamientosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Tratamientos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Tratamiento> GetTratamientos()
    {
      var items = this.context.Tratamientos.AsQueryable<Models.Agriculturebd.Tratamiento>();

      this.OnTratamientosRead(ref items);

      return items;
    }

    partial void OnTratamientosRead(ref IQueryable<Models.Agriculturebd.Tratamiento> items);

    [HttpGet("{Id}")]
    public IActionResult GetTratamiento(Int64 key)
    {
        var item = this.context.Tratamientos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnTratamientoDeleted(Models.Agriculturebd.Tratamiento item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteTratamiento(Int64 key)
    {
        var item = this.context.Tratamientos
            .Where(i => i.Id == key)
            .Include(i => i.ControlPlagas)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnTratamientoDeleted(item);
        this.context.Tratamientos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTratamientoUpdated(Models.Agriculturebd.Tratamiento item);

    [HttpPut("{Id}")]
    public IActionResult PutTratamiento(Int64 key, [FromBody]Models.Agriculturebd.Tratamiento newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnTratamientoUpdated(newItem);
        this.context.Tratamientos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchTratamiento(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Tratamientos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnTratamientoUpdated(item);
        this.context.Tratamientos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTratamientoCreated(Models.Agriculturebd.Tratamiento item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Tratamiento item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnTratamientoCreated(item);
        this.context.Tratamientos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Tratamientos/{item.Id}", item);
    }
  }
}
