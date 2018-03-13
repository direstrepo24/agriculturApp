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
  [ODataRoute("odata/agriculturebd/ProductCategoria")]
  [Route("mvc/odata/agriculturebd/ProductCategoria")]
  public partial class ProductCategoriaController : Controller
  {
    private Data.AgriculturebdContext context;

    public ProductCategoriaController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/ProductCategoria
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.ProductCategorium> GetProductCategoria()
    {
      var items = this.context.ProductCategoria.AsQueryable<Models.Agriculturebd.ProductCategorium>();

      this.OnProductCategoriaRead(ref items);

      return items;
    }

    partial void OnProductCategoriaRead(ref IQueryable<Models.Agriculturebd.ProductCategorium> items);

    [HttpGet("{Id}")]
    public IActionResult GetProductCategorium(Int64 key)
    {
        var item = this.context.ProductCategoria.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnProductCategoriumDeleted(Models.Agriculturebd.ProductCategorium item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteProductCategorium(Int64 key)
    {
        var item = this.context.ProductCategoria
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnProductCategoriumDeleted(item);
        this.context.ProductCategoria.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnProductCategoriumUpdated(Models.Agriculturebd.ProductCategorium item);

    [HttpPut("{Id}")]
    public IActionResult PutProductCategorium(Int64 key, [FromBody]Models.Agriculturebd.ProductCategorium newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnProductCategoriumUpdated(newItem);
        this.context.ProductCategoria.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchProductCategorium(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.ProductCategoria.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnProductCategoriumUpdated(item);
        this.context.ProductCategoria.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnProductCategoriumCreated(Models.Agriculturebd.ProductCategorium item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.ProductCategorium item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnProductCategoriumCreated(item);
        this.context.ProductCategoria.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/ProductCategoria/{item.Id}", item);
    }
  }
}
