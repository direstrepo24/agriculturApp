using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Compras")]
  public class Compra
  {
    public string CodigoCupon
    {
      get;
      set;
    }
    public int CompraStatus
    {
      get;
      set;
    }
    public DateTime CreatedOn
    {
      get;
      set;
    }
    public decimal Descuento
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


    [InverseProperty("Compra")]
    public ICollection<ComprasPago> ComprasPagos { get; set; }

    [InverseProperty("Compra")]
    public ICollection<DetalleCompra> DetalleCompras { get; set; }
    public decimal Impuesto
    {
      get;
      set;
    }
    public string MetodoPago
    {
      get;
      set;
    }
    public decimal TotalCompra
    {
      get;
      set;
    }
    public DateTime UpdatedOn
    {
      get;
      set;
    }
    public Int64 UsuarioId
    {
      get;
      set;
    }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }
  }
}
