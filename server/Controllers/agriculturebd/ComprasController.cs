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
  [ODataRoute("odata/agriculturebd/Compras")]
  [Route("mvc/odata/agriculturebd/Compras")]
  public partial class ComprasController : Controller
  {
    private Data.AgriculturebdContext context;

    public ComprasController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Compras
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Compra> GetCompras()
    {
      var items = this.context.Compras.AsQueryable<Models.Agriculturebd.Compra>();

      this.OnComprasRead(ref items);

      return items;
    }

    partial void OnComprasRead(ref IQueryable<Models.Agriculturebd.Compra> items);

    [HttpGet("{Id}")]
    public IActionResult GetCompra(Int64 key)
    {
        var item = this.context.Compras.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnCompraDeleted(Models.Agriculturebd.Compra item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteCompra(Int64 key)
    {
        var item = this.context.Compras
            .Where(i => i.Id == key)
            .Include(i => i.ComprasPagos)
            .Include(i => i.DetalleCompras)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnCompraDeleted(item);
        this.context.Compras.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCompraUpdated(Models.Agriculturebd.Compra item);

    [HttpPut("{Id}")]
    public IActionResult PutCompra(Int64 key, [FromBody]Models.Agriculturebd.Compra newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnCompraUpdated(newItem);
        this.context.Compras.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchCompra(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Compras.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnCompraUpdated(item);
        this.context.Compras.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCompraCreated(Models.Agriculturebd.Compra item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Compra item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnCompraCreated(item);
        this.context.Compras.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Compras/{item.Id}", item);
    }
  }
}
