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
  [ODataRoute("odata/agriculturebd/MetodoPagos")]
  [Route("mvc/odata/agriculturebd/MetodoPagos")]
  public partial class MetodoPagosController : Controller
  {
    private Data.AgriculturebdContext context;

    public MetodoPagosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/MetodoPagos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.MetodoPago> GetMetodoPagos()
    {
      var items = this.context.MetodoPagos.AsQueryable<Models.Agriculturebd.MetodoPago>();

      this.OnMetodoPagosRead(ref items);

      return items;
    }

    partial void OnMetodoPagosRead(ref IQueryable<Models.Agriculturebd.MetodoPago> items);

    [HttpGet("{Id}")]
    public IActionResult GetMetodoPago(int key)
    {
        var item = this.context.MetodoPagos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnMetodoPagoDeleted(Models.Agriculturebd.MetodoPago item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteMetodoPago(int key)
    {
        var item = this.context.MetodoPagos
            .Where(i => i.Id == key)
            .Include(i => i.DetalleMetodopagos)
            .Include(i => i.Pagos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnMetodoPagoDeleted(item);
        this.context.MetodoPagos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnMetodoPagoUpdated(Models.Agriculturebd.MetodoPago item);

    [HttpPut("{Id}")]
    public IActionResult PutMetodoPago(int key, [FromBody]Models.Agriculturebd.MetodoPago newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnMetodoPagoUpdated(newItem);
        this.context.MetodoPagos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchMetodoPago(int key, [FromBody]JObject patch)
    {
        var item = this.context.MetodoPagos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnMetodoPagoUpdated(item);
        this.context.MetodoPagos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnMetodoPagoCreated(Models.Agriculturebd.MetodoPago item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.MetodoPago item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnMetodoPagoCreated(item);
        this.context.MetodoPagos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/MetodoPagos/{item.Id}", item);
    }
  }
}
