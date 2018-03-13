using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Receta")]
  public class Recetum
  {
    public float Dosis
    {
      get;
      set;
    }
    public Int64 EquipoId
    {
      get;
      set;
    }

    [ForeignKey("EquipoId")]
    public Equipo Equipo { get; set; }
    [Key]
    public Int64 Id
    {
      get;
      set;
    }
    public Int64 InsumoId
    {
      get;
      set;
    }

    [ForeignKey("InsumoId")]
    public Insumo Insumo { get; set; }
    public string Modo_uso
    {
      get;
      set;
    }
    public int UnidadId
    {
      get;
      set;
    }

    [ForeignKey("UnidadId")]
    public UnidadMedida UnidadMedida { get; set; }
    public string nombre
    {
      get;
      set;
    }
  }
}
