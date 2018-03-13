using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("DetalleCompra")]
  public class DetalleCompra
  {
    public Int64 ComprasId
    {
      get;
      set;
    }

    [ForeignKey("ComprasId")]
    public Compra Compra { get; set; }
    [Key]
    public Int64 Id
    {
      get;
      set;
    }
    public decimal? Impuesto
    {
      get;
      set;
    }
    public decimal Precio
    {
      get;
      set;
    }
    public Int64 ProductoId
    {
      get;
      set;
    }

    [ForeignKey("ProductoId")]
    public Producto Producto { get; set; }
    public decimal Quantity
    {
      get;
      set;
    }
    public string descripcion
    {
      get;
      set;
    }
  }
}
