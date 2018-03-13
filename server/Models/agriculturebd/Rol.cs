using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Rol")]
  public class Rol
  {
    [Key]
    public int Id
    {
      get;
      set;
    }


    [InverseProperty("Rol")]
    public ICollection<Usuario> Usuarios { get; set; }
    public string Nombre
    {
      get;
      set;
    }
  }
}
