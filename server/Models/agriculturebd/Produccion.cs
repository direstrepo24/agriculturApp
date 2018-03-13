using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Produccion")]
  public class Produccion
  {
    public Int64 CultivoId
    {
      get;
      set;
    }

    [ForeignKey("CultivoId")]
    public Cultivo Cultivo { get; set; }
    public DateTime FechaFin
    {
      get;
      set;
    }
    public DateTime FechaInicio
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
    public decimal produccionEstimada
    {
      get;
      set;
    }
    public int unidadMedidaId
    {
      get;
      set;
    }

    [ForeignKey("unidadMedidaId")]
    public UnidadMedida UnidadMedida { get; set; }
  }
}
