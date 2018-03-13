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
  [ODataRoute("odata/agriculturebd/Categoria")]
  [Route("mvc/odata/agriculturebd/Categoria")]
  public partial class CategoriaController : Controller
  {
    private Data.AgriculturebdContext context;

    public CategoriaController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Categoria
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Categorium> GetCategoria()
    {
      var items = this.context.Categoria.AsQueryable<Models.Agriculturebd.Categorium>();

      this.OnCategoriaRead(ref items);

      return items;
    }

    partial void OnCategoriaRead(ref IQueryable<Models.Agriculturebd.Categorium> items);

    [HttpGet("{Id}")]
    public IActionResult GetCategorium(int key)
    {
        var item = this.context.Categoria.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnCategoriumDeleted(Models.Agriculturebd.Categorium item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteCategorium(int key)
    {
        var item = this.context.Categoria
            .Where(i => i.Id == key)
            .Include(i => i.Productos)
            .Include(i => i.ProductCategoria)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnCategoriumDeleted(item);
        this.context.Categoria.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCategoriumUpdated(Models.Agriculturebd.Categorium item);

    [HttpPut("{Id}")]
    public IActionResult PutCategorium(int key, [FromBody]Models.Agriculturebd.Categorium newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnCategoriumUpdated(newItem);
        this.context.Categoria.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchCategorium(int key, [FromBody]JObject patch)
    {
        var item = this.context.Categoria.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnCategoriumUpdated(item);
        this.context.Categoria.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCategoriumCreated(Models.Agriculturebd.Categorium item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Categorium item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnCategoriumCreated(item);
        this.context.Categoria.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Categoria/{item.Id}", item);
    }
  }
}
