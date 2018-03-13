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
  [ODataRoute("odata/agriculturebd/Departamentos")]
  [Route("mvc/odata/agriculturebd/Departamentos")]
  public partial class DepartamentosController : Controller
  {
    private Data.AgriculturebdContext context;

    public DepartamentosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Departamentos
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Departamento> GetDepartamentos()
    {
      var items = this.context.Departamentos.AsQueryable<Models.Agriculturebd.Departamento>();

      this.OnDepartamentosRead(ref items);

      return items;
    }

    partial void OnDepartamentosRead(ref IQueryable<Models.Agriculturebd.Departamento> items);

    [HttpGet("{Id}")]
    public IActionResult GetDepartamento(Int64 key)
    {
        var item = this.context.Departamentos.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnDepartamentoDeleted(Models.Agriculturebd.Departamento item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteDepartamento(Int64 key)
    {
        var item = this.context.Departamentos
            .Where(i => i.Id == key)
            .Include(i => i.Ciudads)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnDepartamentoDeleted(item);
        this.context.Departamentos.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDepartamentoUpdated(Models.Agriculturebd.Departamento item);

    [HttpPut("{Id}")]
    public IActionResult PutDepartamento(Int64 key, [FromBody]Models.Agriculturebd.Departamento newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnDepartamentoUpdated(newItem);
        this.context.Departamentos.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchDepartamento(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Departamentos.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnDepartamentoUpdated(item);
        this.context.Departamentos.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnDepartamentoCreated(Models.Agriculturebd.Departamento item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Departamento item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnDepartamentoCreated(item);
        this.context.Departamentos.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Departamentos/{item.Id}", item);
    }
  }
}
