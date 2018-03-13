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
  [ODataRoute("odata/agriculturebd/Produccions")]
  [Route("mvc/odata/agriculturebd/Produccions")]
  public partial class ProduccionsController : Controller
  {
    private Data.AgriculturebdContext context;

    public ProduccionsController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Produccions
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Produccion> GetProduccions()
    {
      var items = this.context.Produccions.AsQueryable<Models.Agriculturebd.Produccion>();

      this.OnProduccionsRead(ref items);

      return items;
    }

    partial void OnProduccionsRead(ref IQueryable<Models.Agriculturebd.Produccion> items);

    [HttpGet("{Id}")]
    public IActionResult GetProduccion(Int64 key)
    {
        var item = this.context.Produccions.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnProduccionDeleted(Models.Agriculturebd.Produccion item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteProduccion(Int64 key)
    {
        var item = this.context.Produccions
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnProduccionDeleted(item);
        this.context.Produccions.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnProduccionUpdated(Models.Agriculturebd.Produccion item);

    [HttpPut("{Id}")]
    public IActionResult PutProduccion(Int64 key, [FromBody]Models.Agriculturebd.Produccion newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnProduccionUpdated(newItem);
        this.context.Produccions.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchProduccion(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Produccions.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnProduccionUpdated(item);
        this.context.Produccions.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnProduccionCreated(Models.Agriculturebd.Produccion item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Produccion item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnProduccionCreated(item);
        this.context.Produccions.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Produccions/{item.Id}", item);
    }
  }
}
