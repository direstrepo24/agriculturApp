using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Ciudad")]
  public class Ciudad
  {
    [Key]
    public Int64 Id
    {
      get;
      set;
    }


    [InverseProperty("Ciudad")]
    public ICollection<UnidadProductiva> UnidadProductivas { get; set; }
    public string Nombre
    {
      get;
      set;
    }
    public Int64 departmentoId
    {
      get;
      set;
    }

    [ForeignKey("departmentoId")]
    public Departamento Departamento { get; set; }
  }
}
