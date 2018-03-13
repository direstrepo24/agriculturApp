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
  [ODataRoute("odata/agriculturebd/UnidadMedidas")]
  [Route("mvc/odata/agriculturebd/UnidadMedidas")]
  public partial class UnidadMedidasController : Controller
  {
    private Data.AgriculturebdContext context;

    public UnidadMedidasController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/UnidadMedidas
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.UnidadMedida> GetUnidadMedidas()
    {
      var items = this.context.UnidadMedidas.AsQueryable<Models.Agriculturebd.UnidadMedida>();

      this.OnUnidadMedidasRead(ref items);

      return items;
    }

    partial void OnUnidadMedidasRead(ref IQueryable<Models.Agriculturebd.UnidadMedida> items);

    [HttpGet("{Id}")]
    public IActionResult GetUnidadMedida(int key)
    {
        var item = this.context.UnidadMedidas.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnUnidadMedidaDeleted(Models.Agriculturebd.UnidadMedida item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteUnidadMedida(int key)
    {
        var item = this.context.UnidadMedidas
            .Where(i => i.Id == key)
            .Include(i => i.Receta)
            .Include(i => i.UnidadProductivas)
            .Include(i => i.Lotes)
            .Include(i => i.ControlPlagas)
            .Include(i => i.Produccions)
            .Include(i => i.DetalleOferta)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnUnidadMedidaDeleted(item);
        this.context.UnidadMedidas.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnUnidadMedidaUpdated(Models.Agriculturebd.UnidadMedida item);

    [HttpPut("{Id}")]
    public IActionResult PutUnidadMedida(int key, [FromBody]Models.Agriculturebd.UnidadMedida newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnUnidadMedidaUpdated(newItem);
        this.context.UnidadMedidas.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchUnidadMedida(int key, [FromBody]JObject patch)
    {
        var item = this.context.UnidadMedidas.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnUnidadMedidaUpdated(item);
        this.context.UnidadMedidas.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnUnidadMedidaCreated(Models.Agriculturebd.UnidadMedida item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.UnidadMedida item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnUnidadMedidaCreated(item);
        this.context.UnidadMedidas.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/UnidadMedidas/{item.Id}", item);
    }
  }
}
