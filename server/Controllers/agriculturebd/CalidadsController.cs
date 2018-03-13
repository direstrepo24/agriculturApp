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
  [ODataRoute("odata/agriculturebd/Calidads")]
  [Route("mvc/odata/agriculturebd/Calidads")]
  public partial class CalidadsController : Controller
  {
    private Data.AgriculturebdContext context;

    public CalidadsController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Calidads
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Calidad> GetCalidads()
    {
      var items = this.context.Calidads.AsQueryable<Models.Agriculturebd.Calidad>();

      this.OnCalidadsRead(ref items);

      return items;
    }

    partial void OnCalidadsRead(ref IQueryable<Models.Agriculturebd.Calidad> items);

    [HttpGet("{Id}")]
    public IActionResult GetCalidad(Int64 key)
    {
        var item = this.context.Calidads.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnCalidadDeleted(Models.Agriculturebd.Calidad item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteCalidad(Int64 key)
    {
        var item = this.context.Calidads
            .Where(i => i.Id == key)
            .Include(i => i.Productos)
            .Include(i => i.DetalleOferta)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnCalidadDeleted(item);
        this.context.Calidads.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCalidadUpdated(Models.Agriculturebd.Calidad item);

    [HttpPut("{Id}")]
    public IActionResult PutCalidad(Int64 key, [FromBody]Models.Agriculturebd.Calidad newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnCalidadUpdated(newItem);
        this.context.Calidads.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchCalidad(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Calidads.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnCalidadUpdated(item);
        this.context.Calidads.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCalidadCreated(Models.Agriculturebd.Calidad item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Calidad item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnCalidadCreated(item);
        this.context.Calidads.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Calidads/{item.Id}", item);
    }
  }
}
