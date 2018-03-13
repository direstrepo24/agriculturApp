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
  [ODataRoute("odata/agriculturebd/Pagos")]
  [Route("mvc/odata/agriculturebd/Pagos")]
  public partial class PagosController : Controller
  {
    private Data.AgriculturebdContext context;

    public PagosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Pagos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Pago> GetPagos()
    {
      var items = this.context.Pagos.AsQueryable<Models.Agriculturebd.Pago>();

      this.OnPagosRead(ref items);

      return items;
    }

    partial void OnPagosRead(ref IQueryable<Models.Agriculturebd.Pago> items);

    [HttpGet("{Id}")]
    public IActionResult GetPago(Int64 key)
    {
        var item = this.context.Pagos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnPagoDeleted(Models.Agriculturebd.Pago item);

    [HttpDelete("{Id}")]
    public IActionResult DeletePago(Int64 key)
    {
        var item = this.context.Pagos
            .Where(i => i.Id == key)
            .Include(i => i.ComprasPagos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnPagoDeleted(item);
        this.context.Pagos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnPagoUpdated(Models.Agriculturebd.Pago item);

    [HttpPut("{Id}")]
    public IActionResult PutPago(Int64 key, [FromBody]Models.Agriculturebd.Pago newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnPagoUpdated(newItem);
        this.context.Pagos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchPago(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Pagos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnPagoUpdated(item);
        this.context.Pagos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnPagoCreated(Models.Agriculturebd.Pago item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Pago item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnPagoCreated(item);
        this.context.Pagos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Pagos/{item.Id}", item);
    }
  }
}
