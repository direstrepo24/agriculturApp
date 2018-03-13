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
  [ODataRoute("odata/agriculturebd/ControlPlagas")]
  [Route("mvc/odata/agriculturebd/ControlPlagas")]
  public partial class ControlPlagasController : Controller
  {
    private Data.AgriculturebdContext context;

    public ControlPlagasController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/ControlPlagas
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.ControlPlaga> GetControlPlagas()
    {
      var items = this.context.ControlPlagas.AsQueryable<Models.Agriculturebd.ControlPlaga>();

      this.OnControlPlagasRead(ref items);

      return items;
    }

    partial void OnControlPlagasRead(ref IQueryable<Models.Agriculturebd.ControlPlaga> items);

    [HttpGet("{Id}")]
    public IActionResult GetControlPlaga(Int64 key)
    {
        var item = this.context.ControlPlagas.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnControlPlagaDeleted(Models.Agriculturebd.ControlPlaga item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteControlPlaga(Int64 key)
    {
        var item = this.context.ControlPlagas
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnControlPlagaDeleted(item);
        this.context.ControlPlagas.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnControlPlagaUpdated(Models.Agriculturebd.ControlPlaga item);

    [HttpPut("{Id}")]
    public IActionResult PutControlPlaga(Int64 key, [FromBody]Models.Agriculturebd.ControlPlaga newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnControlPlagaUpdated(newItem);
        this.context.ControlPlagas.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchControlPlaga(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.ControlPlagas.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnControlPlagaUpdated(item);
        this.context.ControlPlagas.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnControlPlagaCreated(Models.Agriculturebd.ControlPlaga item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.ControlPlaga item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnControlPlagaCreated(item);
        this.context.ControlPlagas.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/ControlPlagas/{item.Id}", item);
    }
  }
}
