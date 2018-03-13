using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Ofertas")]
  public class Oferta
  {
    public DateTime CreatedOn
    {
      get;
      set;
    }
    public int EstadoOferta
    {
      get;
      set;
    }
    public int EstadoOfertaId
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


    [InverseProperty("Oferta")]
    public ICollection<DetalleOfertum> DetalleOferta { get; set; }
    public DateTime UpdatedOn
    {
      get;
      set;
    }
    public Int64 UsuarioId
    {
      get;
      set;
    }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }
  }
}
