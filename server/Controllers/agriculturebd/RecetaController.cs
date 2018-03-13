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
  [ODataRoute("odata/agriculturebd/Receta")]
  [Route("mvc/odata/agriculturebd/Receta")]
  public partial class RecetaController : Controller
  {
    private Data.AgriculturebdContext context;

    public RecetaController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Receta
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Recetum> GetReceta()
    {
      var items = this.context.Receta.AsQueryable<Models.Agriculturebd.Recetum>();

      this.OnRecetaRead(ref items);

      return items;
    }

    partial void OnRecetaRead(ref IQueryable<Models.Agriculturebd.Recetum> items);

    [HttpGet("{Id}")]
    public IActionResult GetRecetum(Int64 key)
    {
        var item = this.context.Receta.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnRecetumDeleted(Models.Agriculturebd.Recetum item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteRecetum(Int64 key)
    {
        var item = this.context.Receta
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnRecetumDeleted(item);
        this.context.Receta.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnRecetumUpdated(Models.Agriculturebd.Recetum item);

    [HttpPut("{Id}")]
    public IActionResult PutRecetum(Int64 key, [FromBody]Models.Agriculturebd.Recetum newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnRecetumUpdated(newItem);
        this.context.Receta.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchRecetum(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Receta.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnRecetumUpdated(item);
        this.context.Receta.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnRecetumCreated(Models.Agriculturebd.Recetum item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Recetum item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnRecetumCreated(item);
        this.context.Receta.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Receta/{item.Id}", item);
    }
  }
}
