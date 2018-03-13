using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

using Agriculturapp.Models.Agriculturebd;

namespace Agriculturapp.Data
{
  public partial class AgriculturebdContext : DbContext
  {
    public AgriculturebdContext(DbContextOptions<AgriculturebdContext> options):base(options)
    {
    }

    public AgriculturebdContext()
    {
    }



    public DbSet<Calidad> Calidads
    {
      get;
      set;
    }

    public DbSet<CategoriaInsumo> CategoriaInsumos
    {
      get;
      set;
    }

    public DbSet<Categorium> Categoria
    {
      get;
      set;
    }

    public DbSet<Ciudad> Ciudads
    {
      get;
      set;
    }

    public DbSet<Compra> Compras
    {
      get;
      set;
    }

    public DbSet<ComprasPago> ComprasPagos
    {
      get;
      set;
    }

    public DbSet<ControlPlaga> ControlPlagas
    {
      get;
      set;
    }

    public DbSet<Cultivo> Cultivos
    {
      get;
      set;
    }

    public DbSet<Departamento> Departamentos
    {
      get;
      set;
    }

    public DbSet<DetalleCategoriaInsumo> DetalleCategoriaInsumos
    {
      get;
      set;
    }

    public DbSet<DetalleCompra> DetalleCompras
    {
      get;
      set;
    }

    public DbSet<DetalleMetodopago> DetalleMetodopagos
    {
      get;
      set;
    }

    public DbSet<DetalleOfertum> DetalleOferta
    {
      get;
      set;
    }

    public DbSet<DetalleTipoProducto> DetalleTipoProductos
    {
      get;
      set;
    }

    public DbSet<Enfermedade> Enfermedades
    {
      get;
      set;
    }

    public DbSet<Equipo> Equipos
    {
      get;
      set;
    }

    public DbSet<Foto> Fotos
    {
      get;
      set;
    }

    public DbSet<Insumo> Insumos
    {
      get;
      set;
    }

    public DbSet<Laboratorio> Laboratorios
    {
      get;
      set;
    }

    public DbSet<LocalizacionUp> LocalizacionUps
    {
      get;
      set;
    }

    public DbSet<Lote> Lotes
    {
      get;
      set;
    }

    public DbSet<MetodoPago> MetodoPagos
    {
      get;
      set;
    }

    public DbSet<Notificacione> Notificaciones
    {
      get;
      set;
    }

    public DbSet<Oferta> Oferta
    {
      get;
      set;
    }

    public DbSet<Pago> Pagos
    {
      get;
      set;
    }

    public DbSet<Produccion> Produccions
    {
      get;
      set;
    }

    public DbSet<ProductCategorium> ProductCategoria
    {
      get;
      set;
    }

    public DbSet<Producto> Productos
    {
      get;
      set;
    }

    public DbSet<Recetum> Receta
    {
      get;
      set;
    }

    public DbSet<Rol> Rols
    {
      get;
      set;
    }

    public DbSet<TipoInsumo> TipoInsumos
    {
      get;
      set;
    }

    public DbSet<TipoProducto> TipoProductos
    {
      get;
      set;
    }

    public DbSet<Tratamiento> Tratamientos
    {
      get;
      set;
    }

    public DbSet<TypeNotification> TypeNotifications
    {
      get;
      set;
    }

    public DbSet<UnidadMedida> UnidadMedidas
    {
      get;
      set;
    }

    public DbSet<UnidadProductiva> UnidadProductivas
    {
      get;
      set;
    }

    public DbSet<Usuario> Usuarios
    {
      get;
      set;
    }
  }
}
