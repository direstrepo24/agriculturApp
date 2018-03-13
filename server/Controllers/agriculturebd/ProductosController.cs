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
  [ODataRoute("odata/agriculturebd/Productos")]
  [Route("mvc/odata/agriculturebd/Productos")]
  public partial class ProductosController : Controller
  {
    private Data.AgriculturebdContext context;

    public ProductosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Productos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Producto> GetProductos()
    {
      var items = this.context.Productos.AsQueryable<Models.Agriculturebd.Producto>();

      this.OnProductosRead(ref items);

      return items;
    }

    partial void OnProductosRead(ref IQueryable<Models.Agriculturebd.Producto> items);

    [HttpGet("{Id}")]
    public IActionResult GetProducto(Int64 key)
    {
        var item = this.context.Productos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnProductoDeleted(Models.Agriculturebd.Producto item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteProducto(Int64 key)
    {
        var item = this.context.Productos
            .Where(i => i.Id == key)
            .Include(i => i.DetalleCompras)
            .Include(i => i.DetalleOferta)
            .Include(i => i.ProductCategoria)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnProductoDeleted(item);
        this.context.Productos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnProductoUpdated(Models.Agriculturebd.Producto item);

    [HttpPut("{Id}")]
    public IActionResult PutProducto(Int64 key, [FromBody]Models.Agriculturebd.Producto newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnProductoUpdated(newItem);
        this.context.Productos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchProducto(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Productos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnProductoUpdated(item);
        this.context.Productos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnProductoCreated(Models.Agriculturebd.Producto item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Producto item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnProductoCreated(item);
        this.context.Productos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Productos/{item.Id}", item);
    }
  }
}
