using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Cultivo")]
  public class Cultivo
  {
    public string Descripcion
    {
      get;
      set;
    }
    public Int64 DetalleTipoProductoId
    {
      get;
      set;
    }

    [ForeignKey("DetalleTipoProductoId")]
    public DetalleTipoProducto DetalleTipoProducto { get; set; }
    public decimal EstimadoCosecha
    {
      get;
      set;
    }
    public DateTime FechaFin
    {
      get;
      set;
    }
    public DateTime FechaIncio
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


    [InverseProperty("Cultivo")]
    public ICollection<ControlPlaga> ControlPlagas { get; set; }

    [InverseProperty("Cultivo")]
    public ICollection<Produccion> Produccions { get; set; }

    [InverseProperty("Cultivo")]
    public ICollection<Producto> Productos { get; set; }
    public Int64 LoteId
    {
      get;
      set;
    }

    [ForeignKey("LoteId")]
    public Lote Lote { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
