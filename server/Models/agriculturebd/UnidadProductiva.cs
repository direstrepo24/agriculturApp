using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("UnidadProductiva")]
  public class UnidadProductiva
  {
    public decimal Area
    {
      get;
      set;
    }
    public Int64 CiudadId
    {
      get;
      set;
    }

    [ForeignKey("CiudadId")]
    public Ciudad Ciudad { get; set; }
    public string Codigo
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


    [InverseProperty("UnidadProductiva")]
    public ICollection<LocalizacionUp> LocalizacionUps { get; set; }

    [InverseProperty("UnidadProductiva")]
    public ICollection<Lote> Lotes { get; set; }
    public int UnidadMedidaId
    {
      get;
      set;
    }

    [ForeignKey("UnidadMedidaId")]
    public UnidadMedida UnidadMedida { get; set; }
    public Int64 UsuarioId
    {
      get;
      set;
    }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }
    public string descripcion
    {
      get;
      set;
    }
    public string nombre
    {
      get;
      set;
    }
  }
}
