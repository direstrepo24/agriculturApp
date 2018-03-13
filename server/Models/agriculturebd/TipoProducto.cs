using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("TipoProducto")]
  public class TipoProducto
  {
    [Key]
    public Int64 Id
    {
      get;
      set;
    }


    [InverseProperty("TipoProducto")]
    public ICollection<DetalleTipoProducto> DetalleTipoProductos { get; set; }

    [InverseProperty("TipoProducto")]
    public ICollection<Enfermedade> Enfermedades { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
