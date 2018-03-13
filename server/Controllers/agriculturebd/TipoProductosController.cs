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
  [ODataRoute("odata/agriculturebd/TipoProductos")]
  [Route("mvc/odata/agriculturebd/TipoProductos")]
  public partial class TipoProductosController : Controller
  {
    private Data.AgriculturebdContext context;

    public TipoProductosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/TipoProductos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.TipoProducto> GetTipoProductos()
    {
      var items = this.context.TipoProductos.AsQueryable<Models.Agriculturebd.TipoProducto>();

      this.OnTipoProductosRead(ref items);

      return items;
    }

    partial void OnTipoProductosRead(ref IQueryable<Models.Agriculturebd.TipoProducto> items);

    [HttpGet("{Id}")]
    public IActionResult GetTipoProducto(Int64 key)
    {
        var item = this.context.TipoProductos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnTipoProductoDeleted(Models.Agriculturebd.TipoProducto item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteTipoProducto(Int64 key)
    {
        var item = this.context.TipoProductos
            .Where(i => i.Id == key)
            .Include(i => i.DetalleTipoProductos)
            .Include(i => i.Enfermedades)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnTipoProductoDeleted(item);
        this.context.TipoProductos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTipoProductoUpdated(Models.Agriculturebd.TipoProducto item);

    [HttpPut("{Id}")]
    public IActionResult PutTipoProducto(Int64 key, [FromBody]Models.Agriculturebd.TipoProducto newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnTipoProductoUpdated(newItem);
        this.context.TipoProductos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchTipoProducto(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.TipoProductos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnTipoProductoUpdated(item);
        this.context.TipoProductos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTipoProductoCreated(Models.Agriculturebd.TipoProducto item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.TipoProducto item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnTipoProductoCreated(item);
        this.context.TipoProductos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/TipoProductos/{item.Id}", item);
    }
  }
}
