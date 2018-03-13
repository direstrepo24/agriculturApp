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
  [ODataRoute("odata/agriculturebd/Laboratorios")]
  [Route("mvc/odata/agriculturebd/Laboratorios")]
  public partial class LaboratoriosController : Controller
  {
    private Data.AgriculturebdContext context;

    public LaboratoriosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Laboratorios
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Laboratorio> GetLaboratorios()
    {
      var items = this.context.Laboratorios.AsQueryable<Models.Agriculturebd.Laboratorio>();

      this.OnLaboratoriosRead(ref items);

      return items;
    }

    partial void OnLaboratoriosRead(ref IQueryable<Models.Agriculturebd.Laboratorio> items);

    [HttpGet("{Id}")]
    public IActionResult GetLaboratorio(Int64 key)
    {
        var item = this.context.Laboratorios.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnLaboratorioDeleted(Models.Agriculturebd.Laboratorio item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteLaboratorio(Int64 key)
    {
        var item = this.context.Laboratorios
            .Where(i => i.Id == key)
            .Include(i => i.Insumos)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnLaboratorioDeleted(item);
        this.context.Laboratorios.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnLaboratorioUpdated(Models.Agriculturebd.Laboratorio item);

    [HttpPut("{Id}")]
    public IActionResult PutLaboratorio(Int64 key, [FromBody]Models.Agriculturebd.Laboratorio newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnLaboratorioUpdated(newItem);
        this.context.Laboratorios.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchLaboratorio(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Laboratorios.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnLaboratorioUpdated(item);
        this.context.Laboratorios.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnLaboratorioCreated(Models.Agriculturebd.Laboratorio item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Laboratorio item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnLaboratorioCreated(item);
        this.context.Laboratorios.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Laboratorios/{item.Id}", item);
    }
  }
}
