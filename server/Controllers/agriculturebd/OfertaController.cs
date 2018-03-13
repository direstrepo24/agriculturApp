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
  [ODataRoute("odata/agriculturebd/Oferta")]
  [Route("mvc/odata/agriculturebd/Oferta")]
  public partial class OfertaController : Controller
  {
    private Data.AgriculturebdContext context;

    public OfertaController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Oferta
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Oferta> GetOferta()
    {
      var items = this.context.Oferta.AsQueryable<Models.Agriculturebd.Oferta>();

      this.OnOfertaRead(ref items);

      return items;
    }

    partial void OnOfertaRead(ref IQueryable<Models.Agriculturebd.Oferta> items);

    [HttpGet("{Id}")]
    public IActionResult GetOferta(Int64 key)
    {
        var item = this.context.Oferta.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnOfertaDeleted(Models.Agriculturebd.Oferta item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteOferta(Int64 key)
    {
        var item = this.context.Oferta
            .Where(i => i.Id == key)
            .Include(i => i.DetalleOferta)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnOfertaDeleted(item);
        this.context.Oferta.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnOfertaUpdated(Models.Agriculturebd.Oferta item);

    [HttpPut("{Id}")]
    public IActionResult PutOferta(Int64 key, [FromBody]Models.Agriculturebd.Oferta newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnOfertaUpdated(newItem);
        this.context.Oferta.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchOferta(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Oferta.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnOfertaUpdated(item);
        this.context.Oferta.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnOfertaCreated(Models.Agriculturebd.Oferta item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Oferta item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnOfertaCreated(item);
        this.context.Oferta.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Oferta/{item.Id}", item);
    }
  }
}
