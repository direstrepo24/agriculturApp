using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Foto")]
  public class Foto
  {
    public string Descripcion
    {
      get;
      set;
    }
    public Int64 EnfermedadesId
    {
      get;
      set;
    }

    [ForeignKey("EnfermedadesId")]
    public Enfermedade Enfermedade { get; set; }
    public DateTime FechaCreacion
    {
      get;
      set;
    }
    public string Hora
    {
      get;
      set;
    }
    [Key]
    public Int64 Id
    {
      get;
      set;
    }
    public string Ruta
    {
      get;
      set;
    }
    public string Titulo
    {
      get;
      set;
    }
  }
}
