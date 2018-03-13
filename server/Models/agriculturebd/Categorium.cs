using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Categoria")]
  public class Categorium
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


    [InverseProperty("Categorium")]
    public ICollection<Producto> Productos { get; set; }

    [InverseProperty("Categorium")]
    public ICollection<ProductCategorium> ProductCategoria { get; set; }
    public string Imagen
    {
      get;
      set;
    }
    public string Nombre
    {
      get;
      set;
    }
  }
}
