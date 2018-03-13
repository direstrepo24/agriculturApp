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
  [ODataRoute("odata/agriculturebd/ComprasPagos")]
  [Route("mvc/odata/agriculturebd/ComprasPagos")]
  public partial class ComprasPagosController : Controller
  {
    private Data.AgriculturebdContext context;

    public ComprasPagosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/ComprasPagos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.ComprasPago> GetComprasPagos()
    {
      var items = this.context.ComprasPagos.AsQueryable<Models.Agriculturebd.ComprasPago>();

      this.OnComprasPagosRead(ref items);

      return items;
    }

    partial void OnComprasPagosRead(ref IQueryable<Models.Agriculturebd.ComprasPago> items);

    [HttpGet("{Id}")]
    public IActionResult GetComprasPago(Int64 key)
    {
        var item = this.context.ComprasPagos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnComprasPagoDeleted(Models.Agriculturebd.ComprasPago item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteComprasPago(Int64 key)
    {
        var item = this.context.ComprasPagos
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnComprasPagoDeleted(item);
        this.context.ComprasPagos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnComprasPagoUpdated(Models.Agriculturebd.ComprasPago item);

    [HttpPut("{Id}")]
    public IActionResult PutComprasPago(Int64 key, [FromBody]Models.Agriculturebd.ComprasPago newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnComprasPagoUpdated(newItem);
        this.context.ComprasPagos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchComprasPago(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.ComprasPagos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnComprasPagoUpdated(item);
        this.context.ComprasPagos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnComprasPagoCreated(Models.Agriculturebd.ComprasPago item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.ComprasPago item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnComprasPagoCreated(item);
        this.context.ComprasPagos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/ComprasPagos/{item.Id}", item);
    }
  }
}
