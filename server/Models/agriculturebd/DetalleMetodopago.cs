using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("DetalleMetodopago")]
  public class DetalleMetodopago
  {
    [Key]
    public int Id
    {
      get;
      set;
    }


    [InverseProperty("DetalleMetodopago")]
    public ICollection<Usuario> Usuarios { get; set; }
    public int MetodoPagoId
    {
      get;
      set;
    }

    [ForeignKey("MetodoPagoId")]
    public MetodoPago MetodoPago { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
