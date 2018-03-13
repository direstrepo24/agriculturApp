using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Tipo_Insumo")]
  public class TipoInsumo
  {
    [Key]
    public int Id
    {
      get;
      set;
    }


    [InverseProperty("TipoInsumo")]
    public ICollection<Insumo> Insumos { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
