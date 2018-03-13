using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Calidad")]
  public class Calidad
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


    [InverseProperty("Calidad")]
    public ICollection<Producto> Productos { get; set; }

    [InverseProperty("Calidad")]
    public ICollection<DetalleOfertum> DetalleOferta { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
