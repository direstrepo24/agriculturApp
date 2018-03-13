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
  [ODataRoute("odata/agriculturebd/Ciudads")]
  [Route("mvc/odata/agriculturebd/Ciudads")]
  public partial class CiudadsController : Controller
  {
    private Data.AgriculturebdContext context;

    public CiudadsController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Ciudads
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Ciudad> GetCiudads()
    {
      var items = this.context.Ciudads.AsQueryable<Models.Agriculturebd.Ciudad>();

      this.OnCiudadsRead(ref items);

      return items;
    }

    partial void OnCiudadsRead(ref IQueryable<Models.Agriculturebd.Ciudad> items);

    [HttpGet("{Id}")]
    public IActionResult GetCiudad(Int64 key)
    {
        var item = this.context.Ciudads.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnCiudadDeleted(Models.Agriculturebd.Ciudad item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteCiudad(Int64 key)
    {
        var item = this.context.Ciudads
            .Where(i => i.Id == key)
            .Include(i => i.UnidadProductivas)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnCiudadDeleted(item);
        this.context.Ciudads.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCiudadUpdated(Models.Agriculturebd.Ciudad item);

    [HttpPut("{Id}")]
    public IActionResult PutCiudad(Int64 key, [FromBody]Models.Agriculturebd.Ciudad newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnCiudadUpdated(newItem);
        this.context.Ciudads.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchCiudad(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Ciudads.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnCiudadUpdated(item);
        this.context.Ciudads.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnCiudadCreated(Models.Agriculturebd.Ciudad item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Ciudad item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnCiudadCreated(item);
        this.context.Ciudads.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Ciudads/{item.Id}", item);
    }
  }
}
