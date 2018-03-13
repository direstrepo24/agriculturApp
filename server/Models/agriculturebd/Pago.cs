using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Pagos")]
  public class Pago
  {
    public DateTime CreatedOn
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


    [InverseProperty("Pago")]
    public ICollection<ComprasPago> ComprasPagos { get; set; }
    public int MetodoPagoId
    {
      get;
      set;
    }

    [ForeignKey("MetodoPagoId")]
    public MetodoPago MetodoPago { get; set; }
    public decimal Monto
    {
      get;
      set;
    }
    public decimal? Saldo
    {
      get;
      set;
    }
    public DateTime UpdatedOn
    {
      get;
      set;
    }
  }
}
