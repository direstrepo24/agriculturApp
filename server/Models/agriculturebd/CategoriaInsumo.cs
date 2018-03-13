using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Categoria_Insumo")]
  public class CategoriaInsumo
  {
    [Key]
    public int Id
    {
      get;
      set;
    }


    [InverseProperty("CategoriaInsumo")]
    public ICollection<DetalleCategoriaInsumo> DetalleCategoriaInsumos { get; set; }

    [InverseProperty("CategoriaInsumo")]
    public ICollection<Tratamiento> Tratamientos { get; set; }
    public string Nombre
    {
      get;
      set;
    }
    public string NombreColor
    {
      get;
      set;
    }
    public string codigoColor
    {
      get;
      set;
    }
  }
}
