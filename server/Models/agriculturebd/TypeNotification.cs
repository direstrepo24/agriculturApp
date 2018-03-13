using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("TypeNotification")]
  public class TypeNotification
  {
    [Key]
    public Int64 Id
    {
      get;
      set;
    }


    [InverseProperty("TypeNotification")]
    public ICollection<Notificacione> Notificaciones { get; set; }
    public string Nombre
    {
      get;
      set;
    }
    public string Sigla
    {
      get;
      set;
    }
  }
}
