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
  [ODataRoute("odata/agriculturebd/DetalleTipoProductos")]
  [Route("mvc/odata/agriculturebd/DetalleTipoProductos")]
  public partial class DetalleTipoProductosController : Controller
  {
    private Data.AgriculturebdContext context;

    public DetalleTipoProductosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/DetalleTipoProductos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.DetalleTipoProducto> GetDetalleTipoProductos()
    {
      var items = this.context.DetalleTipoProductos.AsQueryable<Models.Agriculturebd.DetalleTipoProducto>();

      this.OnDetalleTipoProductosRead(ref items);

      return items;
    }

    partial void OnDetalleTipoProductosRead(ref IQueryable<Models.Agriculturebd.DetalleTipoProducto> items);

    [HttpGet("{Id}")]
    public IActionResult GetDetalleTipoProducto(Int64 key)
    {
        var item = this.context.DetalleTipoProductos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnDetalleTipoProductoDeleted(Models.Agriculturebd.DetalleTipoProducto item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteDetalleTipoProducto(Int64 key)
    {
        var item = this.context.DetalleTipoProductos
            .Where(i => i.Id == key)
            .Include(i => i.Cultivos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnDetalleTipoProductoDeleted(item);
        this.context.DetalleTipoProductos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleTipoProductoUpdated(Models.Agriculturebd.DetalleTipoProducto item);

    [HttpPut("{Id}")]
    public IActionResult PutDetalleTipoProducto(Int64 key, [FromBody]Models.Agriculturebd.DetalleTipoProducto newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnDetalleTipoProductoUpdated(newItem);
        this.context.DetalleTipoProductos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchDetalleTipoProducto(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.DetalleTipoProductos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnDetalleTipoProductoUpdated(item);
        this.context.DetalleTipoProductos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleTipoProductoCreated(Models.Agriculturebd.DetalleTipoProducto item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.DetalleTipoProducto item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnDetalleTipoProductoCreated(item);
        this.context.DetalleTipoProductos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/DetalleTipoProductos/{item.Id}", item);
    }
  }
}
