using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("DetalleCategoria_Insumo")]
  public class DetalleCategoriaInsumo
  {
    public int? Categoria_InsumoId
    {
      get;
      set;
    }

    [ForeignKey("Categoria_InsumoId")]
    public CategoriaInsumo CategoriaInsumo { get; set; }
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
    public string Letra
    {
      get;
      set;
    }
  }
}
