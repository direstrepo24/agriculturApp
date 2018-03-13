using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("MetodoPago")]
  public class MetodoPago
  {
    [Key]
    public int Id
    {
      get;
      set;
    }


    [InverseProperty("MetodoPago")]
    public ICollection<DetalleMetodopago> DetalleMetodopagos { get; set; }

    [InverseProperty("MetodoPago")]
    public ICollection<Pago> Pagos { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
