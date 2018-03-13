using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Usuario")]
  public class Usuario
  {
    public string Apellidos
    {
      get;
      set;
    }
    public int DetallemetodoPagoId
    {
      get;
      set;
    }

    [ForeignKey("DetallemetodoPagoId")]
    public DetalleMetodopago DetalleMetodopago { get; set; }
    public string Email
    {
      get;
      set;
    }
    public bool EmailConfirmed
    {
      get;
      set;
    }
    public string Estado
    {
      get;
      set;
    }
    public DateTime? FechaRegistro
    {
      get;
      set;
    }
    public string Fotopefil
    {
      get;
      set;
    }
    [Key]
    public Int64 Id
    {
      get;
      set;
    }


    [InverseProperty("Usuario")]
    public ICollection<Compra> Compras { get; set; }

    [InverseProperty("Usuario")]
    public ICollection<Oferta> Oferta { get; set; }

    [InverseProperty("Usuario")]
    public ICollection<UnidadProductiva> UnidadProductivas { get; set; }
    public string Identificacion
    {
      get;
      set;
    }
    public string Nombre
    {
      get;
      set;
    }
    public string Nro_movil
    {
      get;
      set;
    }
    public string NumeroCuenta
    {
      get;
      set;
    }
    public string PhoneNumber
    {
      get;
      set;
    }
    public bool PhoneNumberConfirmed
    {
      get;
      set;
    }
    public int RolId
    {
      get;
      set;
    }

    [ForeignKey("RolId")]
    public Rol Rol { get; set; }
    public string UserName
    {
      get;
      set;
    }
  }
}
