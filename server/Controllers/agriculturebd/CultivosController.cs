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
  [ODataRoute("odata/agriculturebd/Cultivos")]
  [Route("mvc/odata/agriculturebd/Cultivos")]
  public partial class CultivosController : Controller
  {
    private Data.AgriculturebdContext context;

    public CultivosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Cultivos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Cultivo> GetCultivos()
    {
      var items = this.context.Cultivos.AsQueryable<Models.Agriculturebd.Cultivo>();

      this.OnCultivosRead(ref items);

      return items;
    }

    partial void OnCultivosRead(ref IQueryable<Models.Agriculturebd.Cultivo> items);

    [HttpGet("{Id}")]
    public IActionResult GetCultivo(Int64 key)
    {
        var item = this.context.Cultivos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnCultivoDeleted(Models.Agriculturebd.Cultivo item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteCultivo(Int64 key)
    {
        var item = this.context.Cultivos
            .Where(i => i.Id == key)
            .Include(i => i.ControlPlagas)
            .Include(i => i.Produccions)
            .Include(i => i.Productos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnCultivoDeleted(item);
        this.context.Cultivos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCultivoUpdated(Models.Agriculturebd.Cultivo item);

    [HttpPut("{Id}")]
    public IActionResult PutCultivo(Int64 key, [FromBody]Models.Agriculturebd.Cultivo newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnCultivoUpdated(newItem);
        this.context.Cultivos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchCultivo(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Cultivos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnCultivoUpdated(item);
        this.context.Cultivos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCultivoCreated(Models.Agriculturebd.Cultivo item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Cultivo item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnCultivoCreated(item);
        this.context.Cultivos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Cultivos/{item.Id}", item);
    }
  }
}
