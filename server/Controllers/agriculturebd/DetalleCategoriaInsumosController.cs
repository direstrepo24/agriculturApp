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
  [ODataRoute("odata/agriculturebd/DetalleCategoriaInsumos")]
  [Route("mvc/odata/agriculturebd/DetalleCategoriaInsumos")]
  public partial class DetalleCategoriaInsumosController : Controller
  {
    private Data.AgriculturebdContext context;

    public DetalleCategoriaInsumosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/DetalleCategoriaInsumos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.DetalleCategoriaInsumo> GetDetalleCategoriaInsumos()
    {
      var items = this.context.DetalleCategoriaInsumos.AsQueryable<Models.Agriculturebd.DetalleCategoriaInsumo>();

      this.OnDetalleCategoriaInsumosRead(ref items);

      return items;
    }

    partial void OnDetalleCategoriaInsumosRead(ref IQueryable<Models.Agriculturebd.DetalleCategoriaInsumo> items);

    [HttpGet("{Id}")]
    public IActionResult GetDetalleCategoriaInsumo(int key)
    {
        var item = this.context.DetalleCategoriaInsumos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnDetalleCategoriaInsumoDeleted(Models.Agriculturebd.DetalleCategoriaInsumo item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteDetalleCategoriaInsumo(int key)
    {
        var item = this.context.DetalleCategoriaInsumos
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnDetalleCategoriaInsumoDeleted(item);
        this.context.DetalleCategoriaInsumos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleCategoriaInsumoUpdated(Models.Agriculturebd.DetalleCategoriaInsumo item);

    [HttpPut("{Id}")]
    public IActionResult PutDetalleCategoriaInsumo(int key, [FromBody]Models.Agriculturebd.DetalleCategoriaInsumo newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnDetalleCategoriaInsumoUpdated(newItem);
        this.context.DetalleCategoriaInsumos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchDetalleCategoriaInsumo(int key, [FromBody]JObject patch)
    {
        var item = this.context.DetalleCategoriaInsumos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnDetalleCategoriaInsumoUpdated(item);
        this.context.DetalleCategoriaInsumos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleCategoriaInsumoCreated(Models.Agriculturebd.DetalleCategoriaInsumo item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.DetalleCategoriaInsumo item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnDetalleCategoriaInsumoCreated(item);
        this.context.DetalleCategoriaInsumos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/DetalleCategoriaInsumos/{item.Id}", item);
    }
  }
}
