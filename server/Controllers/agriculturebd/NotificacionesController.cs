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
  [ODataRoute("odata/agriculturebd/Notificaciones")]
  [Route("mvc/odata/agriculturebd/Notificaciones")]
  public partial class NotificacionesController : Controller
  {
    private Data.AgriculturebdContext context;

    public NotificacionesController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Notificaciones
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Notificacione> GetNotificaciones()
    {
      var items = this.context.Notificaciones.AsQueryable<Models.Agriculturebd.Notificacione>();

      this.OnNotificacionesRead(ref items);

      return items;
    }

    partial void OnNotificacionesRead(ref IQueryable<Models.Agriculturebd.Notificacione> items);

    [HttpGet("{Id}")]
    public IActionResult GetNotificacione(Int64 key)
    {
        var item = this.context.Notificaciones.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnNotificacioneDeleted(Models.Agriculturebd.Notificacione item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteNotificacione(Int64 key)
    {
        var item = this.context.Notificaciones
            .Where(i => i.Id == key)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnNotificacioneDeleted(item);
        this.context.Notificaciones.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnNotificacioneUpdated(Models.Agriculturebd.Notificacione item);

    [HttpPut("{Id}")]
    public IActionResult PutNotificacione(Int64 key, [FromBody]Models.Agriculturebd.Notificacione newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnNotificacioneUpdated(newItem);
        this.context.Notificaciones.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchNotificacione(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Notificaciones.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnNotificacioneUpdated(item);
        this.context.Notificaciones.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnNotificacioneCreated(Models.Agriculturebd.Notificacione item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Notificacione item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnNotificacioneCreated(item);
        this.context.Notificaciones.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Notificaciones/{item.Id}", item);
    }
  }
}
