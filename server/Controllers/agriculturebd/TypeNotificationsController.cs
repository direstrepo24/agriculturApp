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
  [ODataRoute("odata/agriculturebd/TypeNotifications")]
  [Route("mvc/odata/agriculturebd/TypeNotifications")]
  public partial class TypeNotificationsController : Controller
  {
    private Data.AgriculturebdContext context;

    public TypeNotificationsController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/TypeNotifications
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.TypeNotification> GetTypeNotifications()
    {
      var items = this.context.TypeNotifications.AsQueryable<Models.Agriculturebd.TypeNotification>();

      this.OnTypeNotificationsRead(ref items);

      return items;
    }

    partial void OnTypeNotificationsRead(ref IQueryable<Models.Agriculturebd.TypeNotification> items);

    [HttpGet("{Id}")]
    public IActionResult GetTypeNotification(Int64 key)
    {
        var item = this.context.TypeNotifications.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnTypeNotificationDeleted(Models.Agriculturebd.TypeNotification item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteTypeNotification(Int64 key)
    {
        var item = this.context.TypeNotifications
            .Where(i => i.Id == key)
            .Include(i => i.Notificaciones)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnTypeNotificationDeleted(item);
        this.context.TypeNotifications.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTypeNotificationUpdated(Models.Agriculturebd.TypeNotification item);

    [HttpPut("{Id}")]
    public IActionResult PutTypeNotification(Int64 key, [FromBody]Models.Agriculturebd.TypeNotification newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnTypeNotificationUpdated(newItem);
        this.context.TypeNotifications.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchTypeNotification(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.TypeNotifications.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnTypeNotificationUpdated(item);
        this.context.TypeNotifications.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnTypeNotificationCreated(Models.Agriculturebd.TypeNotification item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.TypeNotification item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnTypeNotificationCreated(item);
        this.context.TypeNotifications.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/TypeNotifications/{item.Id}", item);
    }
  }
}
