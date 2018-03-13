using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Insumo")]
  public class Insumo
  {
    public string Descripcion
    {
      get;
      set;
    }
    public DateTime Fecha_Vencimiento
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


    [InverseProperty("Insumo")]
    public ICollection<Recetum> Receta { get; set; }

    [InverseProperty("Insumo")]
    public ICollection<Tratamiento> Tratamientos { get; set; }
    public string Nombre
    {
      get;
      set;
    }
    public int Tipo_InsumoId
    {
      get;
      set;
    }

    [ForeignKey("Tipo_InsumoId")]
    public TipoInsumo TipoInsumo { get; set; }
    public Int64 laboratorioId
    {
      get;
      set;
    }

    [ForeignKey("laboratorioId")]
    public Laboratorio Laboratorio { get; set; }
    public string lote_laboratorio
    {
      get;
      set;
    }
  }
}
