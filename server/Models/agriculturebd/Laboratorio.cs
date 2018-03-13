using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Laboratorio")]
  public class Laboratorio
  {
    [Key]
    public Int64 Id
    {
      get;
      set;
    }


    [InverseProperty("Laboratorio")]
    public ICollection<Insumo> Insumos { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
