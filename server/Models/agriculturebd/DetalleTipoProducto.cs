using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("DetalleTipoProducto")]
  public class DetalleTipoProducto
  {
    public string Descripcion
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


    [InverseProperty("DetalleTipoProducto")]
    public ICollection<Cultivo> Cultivos { get; set; }
    public string Nombre
    {
      get;
      set;
    }
    public Int64 TipoProductoId
    {
      get;
      set;
    }

    [ForeignKey("TipoProductoId")]
    public TipoProducto TipoProducto { get; set; }
  }
}
