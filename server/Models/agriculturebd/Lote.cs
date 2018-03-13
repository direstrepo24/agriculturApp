using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Lote")]
  public class Lote
  {
    public float Area
    {
      get;
      set;
    }
    public string Codigo
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


    [InverseProperty("Lote")]
    public ICollection<Cultivo> Cultivos { get; set; }
    public string Localizacion
    {
      get;
      set;
    }
    public string Localizacion_Poligono
    {
      get;
      set;
    }
    public int UnidadMedidaId
    {
      get;
      set;
    }

    [ForeignKey("UnidadMedidaId")]
    public UnidadMedida UnidadMedida { get; set; }
    public Int64 unidadproductivaId
    {
      get;
      set;
    }

    [ForeignKey("unidadproductivaId")]
    public UnidadProductiva UnidadProductiva { get; set; }
  }
}
