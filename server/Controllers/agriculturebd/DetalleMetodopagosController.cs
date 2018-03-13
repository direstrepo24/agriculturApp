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
  [ODataRoute("odata/agriculturebd/DetalleMetodopagos")]
  [Route("mvc/odata/agriculturebd/DetalleMetodopagos")]
  public partial class DetalleMetodopagosController : Controller
  {
    private Data.AgriculturebdContext context;

    public DetalleMetodopagosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/DetalleMetodopagos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.DetalleMetodopago> GetDetalleMetodopagos()
    {
      var items = this.context.DetalleMetodopagos.AsQueryable<Models.Agriculturebd.DetalleMetodopago>();

      this.OnDetalleMetodopagosRead(ref items);

      return items;
    }

    partial void OnDetalleMetodopagosRead(ref IQueryable<Models.Agriculturebd.DetalleMetodopago> items);

    [HttpGet("{Id}")]
    public IActionResult GetDetalleMetodopago(int key)
    {
        var item = this.context.DetalleMetodopagos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnDetalleMetodopagoDeleted(Models.Agriculturebd.DetalleMetodopago item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteDetalleMetodopago(int key)
    {
        var item = this.context.DetalleMetodopagos
            .Where(i => i.Id == key)
            .Include(i => i.Usuarios)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnDetalleMetodopagoDeleted(item);
        this.context.DetalleMetodopagos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleMetodopagoUpdated(Models.Agriculturebd.DetalleMetodopago item);

    [HttpPut("{Id}")]
    public IActionResult PutDetalleMetodopago(int key, [FromBody]Models.Agriculturebd.DetalleMetodopago newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnDetalleMetodopagoUpdated(newItem);
        this.context.DetalleMetodopagos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchDetalleMetodopago(int key, [FromBody]JObject patch)
    {
        var item = this.context.DetalleMetodopagos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnDetalleMetodopagoUpdated(item);
        this.context.DetalleMetodopagos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleMetodopagoCreated(Models.Agriculturebd.DetalleMetodopago item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.DetalleMetodopago item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnDetalleMetodopagoCreated(item);
        this.context.DetalleMetodopagos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/DetalleMetodopagos/{item.Id}", item);
    }
  }
}
