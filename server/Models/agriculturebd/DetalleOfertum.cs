using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("DetalleOferta")]
  public class DetalleOfertum
  {
    public Int64 CalidadId
    {
      get;
      set;
    }

    [ForeignKey("CalidadId")]
    public Calidad Calidad { get; set; }
    public decimal Cantidad
    {
      get;
      set;
    }
    [Key]
    public int Id
    {
      get;
      set;
    }
    public Int64? OfertasId
    {
      get;
      set;
    }

    [ForeignKey("OfertasId")]
    public Oferta Oferta { get; set; }
    public Int64 ProductoId
    {
      get;
      set;
    }

    [ForeignKey("ProductoId")]
    public Producto Producto { get; set; }
    public int UnidadMedidaId
    {
      get;
      set;
    }

    [ForeignKey("UnidadMedidaId")]
    public UnidadMedida UnidadMedida { get; set; }
    public decimal Valor_Oferta
    {
      get;
      set;
    }
    public decimal? Valor_minimo
    {
      get;
      set;
    }
    public decimal? Valor_transaccion
    {
      get;
      set;
    }
  }
}
