using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agriculturapp.Models.Agriculturebd
{
  [Table("Producto")]
  public class Producto
  {
    public Int64 CalidadId
    {
      get;
      set;
    }

    [ForeignKey("CalidadId")]
    public Calidad Calidad { get; set; }
    public int CategoriaId
    {
      get;
      set;
    }

    [ForeignKey("CategoriaId")]
    public Categorium Categorium { get; set; }
    public string CodigoUp
    {
      get;
      set;
    }
    public string Descripcion
    {
      get;
      set;
    }
    public DateTime FechaLimiteDisponibilidad
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


    [InverseProperty("Producto")]
    public ICollection<DetalleCompra> DetalleCompras { get; set; }

    [InverseProperty("Producto")]
    public ICollection<DetalleOfertum> DetalleOferta { get; set; }

    [InverseProperty("Producto")]
    public ICollection<ProductCategorium> ProductCategoria { get; set; }
    public string Imagen
    {
      get;
      set;
    }
    public bool IsEnable
    {
      get;
      set;
    }
    public decimal Precio
    {
      get;
      set;
    }
    public decimal? PrecioSpecial
    {
      get;
      set;
    }
    public float Stock
    {
      get;
      set;
    }
    public Int64 cultivoId
    {
      get;
      set;
    }

    [ForeignKey("cultivoId")]
    public Cultivo Cultivo { get; set; }
    public string nombre
    {
      get;
      set;
    }
  }
}
