using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Equipo")]
  public class Equipo
  {
    [Key]
    public Int64 Id
    {
      get;
      set;
    }


    [InverseProperty("Equipo")]
    public ICollection<Recetum> Receta { get; set; }
    public string Marca
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
