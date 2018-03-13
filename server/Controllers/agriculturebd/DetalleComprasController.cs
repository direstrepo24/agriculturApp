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
  [ODataRoute("odata/agriculturebd/DetalleCompras")]
  [Route("mvc/odata/agriculturebd/DetalleCompras")]
  public partial class DetalleComprasController : Controller
  {
    private Data.AgriculturebdContext context;

    public DetalleComprasController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/DetalleCompras
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.DetalleCompra> GetDetalleCompras()
    {
      var items = this.context.DetalleCompras.AsQueryable<Models.Agriculturebd.DetalleCompra>();

      this.OnDetalleComprasRead(ref items);

      return items;
    }

    partial void OnDetalleComprasRead(ref IQueryable<Models.Agriculturebd.DetalleCompra> items);

    [HttpGet("{Id}")]
    public IActionResult GetDetalleCompra(Int64 key)
    {
        var item = this.context.DetalleCompras.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnDetalleCompraDeleted(Models.Agriculturebd.DetalleCompra item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteDetalleCompra(Int64 key)
    {
        var item = this.context.DetalleCompras
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnDetalleCompraDeleted(item);
        this.context.DetalleCompras.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleCompraUpdated(Models.Agriculturebd.DetalleCompra item);

    [HttpPut("{Id}")]
    public IActionResult PutDetalleCompra(Int64 key, [FromBody]Models.Agriculturebd.DetalleCompra newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnDetalleCompraUpdated(newItem);
        this.context.DetalleCompras.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchDetalleCompra(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.DetalleCompras.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnDetalleCompraUpdated(item);
        this.context.DetalleCompras.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleCompraCreated(Models.Agriculturebd.DetalleCompra item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.DetalleCompra item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnDetalleCompraCreated(item);
        this.context.DetalleCompras.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/DetalleCompras/{item.Id}", item);
    }
  }
}
