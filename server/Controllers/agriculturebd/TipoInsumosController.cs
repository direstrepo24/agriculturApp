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
  [ODataRoute("odata/agriculturebd/TipoInsumos")]
  [Route("mvc/odata/agriculturebd/TipoInsumos")]
  public partial class TipoInsumosController : Controller
  {
    private Data.AgriculturebdContext context;

    public TipoInsumosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/TipoInsumos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.TipoInsumo> GetTipoInsumos()
    {
      var items = this.context.TipoInsumos.AsQueryable<Models.Agriculturebd.TipoInsumo>();

      this.OnTipoInsumosRead(ref items);

      return items;
    }

    partial void OnTipoInsumosRead(ref IQueryable<Models.Agriculturebd.TipoInsumo> items);

    [HttpGet("{Id}")]
    public IActionResult GetTipoInsumo(int key)
    {
        var item = this.context.TipoInsumos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnTipoInsumoDeleted(Models.Agriculturebd.TipoInsumo item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteTipoInsumo(int key)
    {
        var item = this.context.TipoInsumos
            .Where(i => i.Id == key)
            .Include(i => i.Insumos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnTipoInsumoDeleted(item);
        this.context.TipoInsumos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTipoInsumoUpdated(Models.Agriculturebd.TipoInsumo item);

    [HttpPut("{Id}")]
    public IActionResult PutTipoInsumo(int key, [FromBody]Models.Agriculturebd.TipoInsumo newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnTipoInsumoUpdated(newItem);
        this.context.TipoInsumos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchTipoInsumo(int key, [FromBody]JObject patch)
    {
        var item = this.context.TipoInsumos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnTipoInsumoUpdated(item);
        this.context.TipoInsumos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTipoInsumoCreated(Models.Agriculturebd.TipoInsumo item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.TipoInsumo item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnTipoInsumoCreated(item);
        this.context.TipoInsumos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/TipoInsumos/{item.Id}", item);
    }
  }
}
