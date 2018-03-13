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
  [ODataRoute("odata/agriculturebd/Insumos")]
  [Route("mvc/odata/agriculturebd/Insumos")]
  public partial class InsumosController : Controller
  {
    private Data.AgriculturebdContext context;

    public InsumosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Insumos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Insumo> GetInsumos()
    {
      var items = this.context.Insumos.AsQueryable<Models.Agriculturebd.Insumo>();

      this.OnInsumosRead(ref items);

      return items;
    }

    partial void OnInsumosRead(ref IQueryable<Models.Agriculturebd.Insumo> items);

    [HttpGet("{Id}")]
    public IActionResult GetInsumo(Int64 key)
    {
        var item = this.context.Insumos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnInsumoDeleted(Models.Agriculturebd.Insumo item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteInsumo(Int64 key)
    {
        var item = this.context.Insumos
            .Where(i => i.Id == key)
            .Include(i => i.Receta)
            .Include(i => i.Tratamientos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnInsumoDeleted(item);
        this.context.Insumos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnInsumoUpdated(Models.Agriculturebd.Insumo item);

    [HttpPut("{Id}")]
    public IActionResult PutInsumo(Int64 key, [FromBody]Models.Agriculturebd.Insumo newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnInsumoUpdated(newItem);
        this.context.Insumos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchInsumo(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Insumos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnInsumoUpdated(item);
        this.context.Insumos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnInsumoCreated(Models.Agriculturebd.Insumo item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Insumo item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnInsumoCreated(item);
        this.context.Insumos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Insumos/{item.Id}", item);
    }
  }
}
