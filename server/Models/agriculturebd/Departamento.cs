using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Departamento")]
  public class Departamento
  {
    [Key]
    public Int64 Id
    {
      get;
      set;
    }


    [InverseProperty("Departamento")]
    public ICollection<Ciudad> Ciudads { get; set; }
    public string Nombre
    {
      get;
      set;
    }
    public Int64 codigodpto
    {
      get;
      set;
    }
  }
}
