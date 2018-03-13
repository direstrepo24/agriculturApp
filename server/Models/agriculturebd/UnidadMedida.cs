using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("UnidadMedida")]
  public class UnidadMedida
  {
    public string Descripcion
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


    [InverseProperty("UnidadMedida")]
    public ICollection<Recetum> Receta { get; set; }

    [InverseProperty("UnidadMedida")]
    public ICollection<UnidadProductiva> UnidadProductivas { get; set; }

    [InverseProperty("UnidadMedida")]
    public ICollection<Lote> Lotes { get; set; }

    [InverseProperty("UnidadMedida")]
    public ICollection<ControlPlaga> ControlPlagas { get; set; }

    [InverseProperty("UnidadMedida")]
    public ICollection<Produccion> Produccions { get; set; }

    [InverseProperty("UnidadMedida")]
    public ICollection<DetalleOfertum> DetalleOferta { get; set; }
    public string Sigla
    {
      get;
      set;
    }
  }
}
