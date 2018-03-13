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
  [ODataRoute("odata/agriculturebd/Lotes")]
  [Route("mvc/odata/agriculturebd/Lotes")]
  public partial class LotesController : Controller
  {
    private Data.AgriculturebdContext context;

    public LotesController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Lotes
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Lote> GetLotes()
    {
      var items = this.context.Lotes.AsQueryable<Models.Agriculturebd.Lote>();

      this.OnLotesRead(ref items);

      return items;
    }

    partial void OnLotesRead(ref IQueryable<Models.Agriculturebd.Lote> items);

    [HttpGet("{Id}")]
    public IActionResult GetLote(Int64 key)
    {
        var item = this.context.Lotes.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnLoteDeleted(Models.Agriculturebd.Lote item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteLote(Int64 key)
    {
        var item = this.context.Lotes
            .Where(i => i.Id == key)
            .Include(i => i.Cultivos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnLoteDeleted(item);
        this.context.Lotes.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnLoteUpdated(Models.Agriculturebd.Lote item);

    [HttpPut("{Id}")]
    public IActionResult PutLote(Int64 key, [FromBody]Models.Agriculturebd.Lote newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnLoteUpdated(newItem);
        this.context.Lotes.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchLote(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Lotes.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnLoteUpdated(item);
        this.context.Lotes.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnLoteCreated(Models.Agriculturebd.Lote item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Lote item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnLoteCreated(item);
        this.context.Lotes.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Lotes/{item.Id}", item);
    }
  }
}
