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
  [ODataRoute("odata/agriculturebd/Usuarios")]
  [Route("mvc/odata/agriculturebd/Usuarios")]
  public partial class UsuariosController : Controller
  {
    private Data.AgriculturebdContext context;

    public UsuariosController(Data.AgriculturebdContext context)
    {
      this.context = context;
    }
    // GET /odata/Agriculturebd/Usuarios
    [HttpGet]
    public IEnumerable<Models.Agriculturebd.Usuario> GetUsuarios()
    {
      var items = this.context.Usuarios.AsQueryable<Models.Agriculturebd.Usuario>();

      this.OnUsuariosRead(ref items);

      return items;
    }

    partial void OnUsuariosRead(ref IQueryable<Models.Agriculturebd.Usuario> items);

    [HttpGet("{Id}")]
    public IActionResult GetUsuario(Int64 key)
    {
        var item = this.context.Usuarios.Where(i=>i.Id == key).SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        return new ObjectResult(item);
    }
    partial void OnUsuarioDeleted(Models.Agriculturebd.Usuario item);

    [HttpDelete("{Id}")]
    public IActionResult DeleteUsuario(Int64 key)
    {
        var item = this.context.Usuarios
            .Where(i => i.Id == key)
            .Include(i => i.Compras)
            .Include(i => i.Oferta)
            .Include(i => i.UnidadProductivas)
            .SingleOrDefault();

        if (item == null)
        {
            return NotFound();
        }

        this.OnUsuarioDeleted(item);
        this.context.Usuarios.Remove(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnUsuarioUpdated(Models.Agriculturebd.Usuario item);

    [HttpPut("{Id}")]
    public IActionResult PutUsuario(Int64 key, [FromBody]Models.Agriculturebd.Usuario newItem)
    {
        if (newItem == null || newItem.Id != key)
        {
            return BadRequest();
        }

        this.OnUsuarioUpdated(newItem);
        this.context.Usuarios.Update(newItem);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    [HttpPatch("{Id}")]
    public IActionResult PatchUsuario(Int64 key, [FromBody]JObject patch)
    {
        var item = this.context.Usuarios.Where(i=>i.Id == key).FirstOrDefault();

        if (item == null)
        {
            return BadRequest();
        }

        Data.EntityPatch.Apply(item, patch);

        this.OnUsuarioUpdated(item);
        this.context.Usuarios.Update(item);
        this.context.SaveChanges();

        return new NoContentResult();
    }

    partial void OnUsuarioCreated(Models.Agriculturebd.Usuario item);

    [HttpPost]
    public IActionResult Post([FromBody] Models.Agriculturebd.Usuario item)
    {
        if (item == null)
        {
            return BadRequest();
        }

        this.OnUsuarioCreated(item);
        this.context.Usuarios.Add(item);
        this.context.SaveChanges();

        return Created($"odata/Agriculturebd/Usuarios/{item.Id}", item);
    }
  }
}
