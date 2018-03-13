using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Tratamiento")]
  public class Tratamiento
  {
    public int Categoria_InsumoId
    {
      get;
      set;
    }

    [ForeignKey("Categoria_InsumoId")]
    public CategoriaInsumo CategoriaInsumo { get; set; }
    public string Desc_Aplicacion
    {
      get;
      set;
    }
    public string Desc_Formulacion
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


    [InverseProperty("Tratamiento")]
    public ICollection<ControlPlaga> ControlPlagas { get; set; }
    public string IngredienteActivo
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
    public string Modo_Accion
    {
      get;
      set;
    }
    public string Nombre_Comercial
    {
      get;
      set;
    }
    public decimal precioAproximado
    {
      get;
      set;
    }
    public string proveedor
    {
      get;
      set;
    }
  }
}
