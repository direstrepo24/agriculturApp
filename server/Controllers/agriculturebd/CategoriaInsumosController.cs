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
  [ODataRoute("odata/agriculturebd/CategoriaInsumos")]
  [Route("mvc/odata/agriculturebd/CategoriaInsumos")]
  public partial class CategoriaInsumosController : Controller
  {
    private Data.AgriculturebdContext context;

    public CategoriaInsumosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/CategoriaInsumos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.CategoriaInsumo> GetCategoriaInsumos()
    {
      var items = this.context.CategoriaInsumos.AsQueryable<Models.Agriculturebd.CategoriaInsumo>();

      this.OnCategoriaInsumosRead(ref items);

      return items;
    }

    partial void OnCategoriaInsumosRead(ref IQueryable<Models.Agriculturebd.CategoriaInsumo> items);

    [HttpGet("{Id}")]
    public IActionResult GetCategoriaInsumo(int key)
    {
        var item = this.context.CategoriaInsumos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnCategoriaInsumoDeleted(Models.Agriculturebd.CategoriaInsumo item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteCategoriaInsumo(int key)
    {
        var item = this.context.CategoriaInsumos
            .Where(i => i.Id == key)
            .Include(i => i.DetalleCategoriaInsumos)
            .Include(i => i.Tratamientos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnCategoriaInsumoDeleted(item);
        this.context.CategoriaInsumos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCategoriaInsumoUpdated(Models.Agriculturebd.CategoriaInsumo item);

    [HttpPut("{Id}")]
    public IActionResult PutCategoriaInsumo(int key, [FromBody]Models.Agriculturebd.CategoriaInsumo newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnCategoriaInsumoUpdated(newItem);
        this.context.CategoriaInsumos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchCategoriaInsumo(int key, [FromBody]JObject patch)
    {
        var item = this.context.CategoriaInsumos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnCategoriaInsumoUpdated(item);
        this.context.CategoriaInsumos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCategoriaInsumoCreated(Models.Agriculturebd.CategoriaInsumo item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.CategoriaInsumo item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnCategoriaInsumoCreated(item);
        this.context.CategoriaInsumos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/CategoriaInsumos/{item.Id}", item);
    }
  }
}
