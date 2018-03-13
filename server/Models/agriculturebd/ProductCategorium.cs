using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("ProductCategoria")]
  public class ProductCategorium
  {
    public int CategoriaId
    {
      get;
      set;
    }

    [ForeignKey("CategoriaId")]
    public Categorium Categorium { get; set; }
    [Key]
    public Int64 Id
    {
      get;
      set;
    }
    public Int64 ProductoId
    {
      get;
      set;
    }

    [ForeignKey("ProductoId")]
    public Producto Producto { get; set; }
  }
}
