using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("ComprasPagos")]
  public class ComprasPago
  {
    public Int64 CompraId
    {
      get;
      set;
    }
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
    public Int64 PagoId
    {
      get;
      set;
    }
    public DateTime UpdatedOn
    {
      get;
      set;
    }
    public Int64? comprasId
    {
      get;
      set;
    }

    [ForeignKey("comprasId")]
    public Compra Compra { get; set; }
    public Int64? pagosId
    {
      get;
      set;
    }

    [ForeignKey("pagosId")]
    public Pago Pago { get; set; }
  }
}
