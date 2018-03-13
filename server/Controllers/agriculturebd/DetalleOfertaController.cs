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
  [ODataRoute("odata/agriculturebd/DetalleOferta")]
  [Route("mvc/odata/agriculturebd/DetalleOferta")]
  public partial class DetalleOfertaController : Controller
  {
    private Data.AgriculturebdContext context;

    public DetalleOfertaController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/DetalleOferta
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.DetalleOfertum> GetDetalleOferta()
    {
      var items = this.context.DetalleOferta.AsQueryable<Models.Agriculturebd.DetalleOfertum>();

      this.OnDetalleOfertaRead(ref items);

      return items;
    }

    partial void OnDetalleOfertaRead(ref IQueryable<Models.Agriculturebd.DetalleOfertum> items);

    [HttpGet("{Id}")]
    public IActionResult GetDetalleOfertum(int key)
    {
        var item = this.context.DetalleOferta.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnDetalleOfertumDeleted(Models.Agriculturebd.DetalleOfertum item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteDetalleOfertum(int key)
    {
        var item = this.context.DetalleOferta
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnDetalleOfertumDeleted(item);
        this.context.DetalleOferta.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleOfertumUpdated(Models.Agriculturebd.DetalleOfertum item);

    [HttpPut("{Id}")]
    public IActionResult PutDetalleOfertum(int key, [FromBody]Models.Agriculturebd.DetalleOfertum newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnDetalleOfertumUpdated(newItem);
        this.context.DetalleOferta.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchDetalleOfertum(int key, [FromBody]JObject patch)
    {
        var item = this.context.DetalleOferta.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnDetalleOfertumUpdated(item);
        this.context.DetalleOferta.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDetalleOfertumCreated(Models.Agriculturebd.DetalleOfertum item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.DetalleOfertum item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnDetalleOfertumCreated(item);
        this.context.DetalleOferta.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/DetalleOferta/{item.Id}", item);
    }
  }
}
