using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("ControlPlaga")]
  public class ControlPlaga
  {
    public Int64 CultivoId
    {
      get;
      set;
    }

    [ForeignKey("CultivoId")]
    public Cultivo Cultivo { get; set; }
    public float Dosis
    {
      get;
      set;
    }
    public Int64 EnfermedadesId
    {
      get;
      set;
    }

    [ForeignKey("EnfermedadesId")]
    public Enfermedade Enfermedade { get; set; }
    public DateTime Fecha_aplicacion
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
    public Int64? TratamientoId
    {
      get;
      set;
    }

    [ForeignKey("TratamientoId")]
    public Tratamiento Tratamiento { get; set; }
    public int UnidadMedidaId
    {
      get;
      set;
    }

    [ForeignKey("UnidadMedidaId")]
    public UnidadMedida UnidadMedida { get; set; }
  }
}
