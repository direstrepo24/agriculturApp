using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("LocalizacionUp")]
  public class LocalizacionUp
  {
    public string Barrio
    {
      get;
      set;
    }
    public string Coordenadas
    {
      get;
      set;
    }
    public string Direccion
    {
      get;
      set;
    }
    public string DireccionAproximadaGps
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
    public decimal Latitud
    {
      get;
      set;
    }
    public string Localidad
    {
      get;
      set;
    }
    public decimal Longitud
    {
      get;
      set;
    }
    public string ReferenciaLocalizacion
    {
      get;
      set;
    }
    public string Sector
    {
      get;
      set;
    }
    public Int64 UnidadProductivaId
    {
      get;
      set;
    }

    [ForeignKey("UnidadProductivaId")]
    public UnidadProductiva UnidadProductiva { get; set; }
    public string vereda
    {
      get;
      set;
    }
  }
}
