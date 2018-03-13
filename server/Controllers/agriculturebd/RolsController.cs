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
  [ODataRoute("odata/agriculturebd/Rols")]
  [Route("mvc/odata/agriculturebd/Rols")]
  public partial class RolsController : Controller
  {
    private Data.AgriculturebdContext context;

    public RolsController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Rols
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Rol> GetRols()
    {
      var items = this.context.Rols.AsQueryable<Models.Agriculturebd.Rol>();

      this.OnRolsRead(ref items);

      return items;
    }

    partial void OnRolsRead(ref IQueryable<Models.Agriculturebd.Rol> items);

    [HttpGet("{Id}")]
    public IActionResult GetRol(int key)
    {
        var item = this.context.Rols.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnRolDeleted(Models.Agriculturebd.Rol item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteRol(int key)
    {
        var item = this.context.Rols
            .Where(i => i.Id == key)
            .Include(i => i.Usuarios)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnRolDeleted(item);
        this.context.Rols.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnRolUpdated(Models.Agriculturebd.Rol item);

    [HttpPut("{Id}")]
    public IActionResult PutRol(int key, [FromBody]Models.Agriculturebd.Rol newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnRolUpdated(newItem);
        this.context.Rols.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchRol(int key, [FromBody]JObject patch)
    {
        var item = this.context.Rols.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnRolUpdated(item);
        this.context.Rols.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnRolCreated(Models.Agriculturebd.Rol item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Rol item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnRolCreated(item);
        this.context.Rols.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Rols/{item.Id}", item);
    }
  }
}
