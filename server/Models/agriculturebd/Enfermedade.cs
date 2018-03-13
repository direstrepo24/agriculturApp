using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Enfermedades")]
  public class Enfermedade
  {
    public string Codigo
    {
      get;
      set;
    }
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


    [InverseProperty("Enfermedade")]
    public ICollection<Foto> Fotos { get; set; }

    [InverseProperty("Enfermedade")]
    public ICollection<ControlPlaga> ControlPlagas { get; set; }
    public string Nombre
    {
      get;
      set;
    }
    public string NombreCientifico
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
