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
  [ODataRoute("odata/agriculturebd/Fotos")]
  [Route("mvc/odata/agriculturebd/Fotos")]
  public partial class FotosController : Controller
  {
    private Data.AgriculturebdContext context;

    public FotosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Fotos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Foto> GetFotos()
    {
      var items = this.context.Fotos.AsQueryable<Models.Agriculturebd.Foto>();

      this.OnFotosRead(ref items);

      return items;
    }

    partial void OnFotosRead(ref IQueryable<Models.Agriculturebd.Foto> items);

    [HttpGet("{Id}")]
    public IActionResult GetFoto(Int64 key)
    {
        var item = this.context.Fotos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnFotoDeleted(Models.Agriculturebd.Foto item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteFoto(Int64 key)
    {
        var item = this.context.Fotos
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnFotoDeleted(item);
        this.context.Fotos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnFotoUpdated(Models.Agriculturebd.Foto item);

    [HttpPut("{Id}")]
    public IActionResult PutFoto(Int64 key, [FromBody]Models.Agriculturebd.Foto newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnFotoUpdated(newItem);
        this.context.Fotos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchFoto(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Fotos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnFotoUpdated(item);
        this.context.Fotos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnFotoCreated(Models.Agriculturebd.Foto item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Foto item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnFotoCreated(item);
        this.context.Fotos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Fotos/{item.Id}", item);
    }
  }
}
