export interface Calidad {
  Descripcion: string;
  DetalleOferta: Array<DetalleOfertum>;
  Id: number;
  Nombre: string;
  Productos: Array<Producto>;
}

export interface CategoriaInsumo {
  DetalleCategoriaInsumos: Array<DetalleCategoriaInsumo>;
  Id: number;
  Nombre: string;
  NombreColor: string;
  Tratamientos: Array<Tratamiento>;
  codigoColor: string;
}

export interface Categorium {
  Descripcion: string;
  Id: number;
  Imagen: string;
  Nombre: string;
  ProductCategoria: Array<ProductCategorium>;
  Productos: Array<Producto>;
}

export interface Ciudad {
  Id: number;
  Nombre: string;
  UnidadProductivas: Array<UnidadProductiva>;
  departmentoId: number;
}

export interface Compra {
  CodigoCupon: string;
  CompraStatus: number;
  ComprasPagos: Array<ComprasPago>;
  CreatedOn: string;
  Descuento: number;
  DetalleCompras: Array<DetalleCompra>;
  Id: number;
  Impuesto: number;
  MetodoPago: string;
  TotalCompra: number;
  UpdatedOn: string;
  UsuarioId: number;
}

export interface ComprasPago {
  CompraId: number;
  CreatedOn: string;
  Id: number;
  PagoId: number;
  UpdatedOn: string;
  comprasId: number;
  pagosId: number;
}

export interface ControlPlaga {
  CultivoId: number;
  Dosis: number;
  EnfermedadesId: number;
  Fecha_aplicacion: string;
  Id: number;
  TratamientoId: number;
  UnidadMedidaId: number;
}

export interface Cultivo {
  ControlPlagas: Array<ControlPlaga>;
  Descripcion: string;
  DetalleTipoProductoId: number;
  EstimadoCosecha: number;
  FechaFin: string;
  FechaIncio: string;
  Id: number;
  LoteId: number;
  Nombre: string;
  Produccions: Array<Produccion>;
  Productos: Array<Producto>;
}

export interface Departamento {
  Ciudads: Array<Ciudad>;
  Id: number;
  Nombre: string;
  codigodpto: number;
}

export interface DetalleCategoriaInsumo {
  Categoria_InsumoId: number;
  Descripcion: string;
  Id: number;
  Letra: string;
}

export interface DetalleCompra {
  ComprasId: number;
  Id: number;
  Impuesto: number;
  Precio: number;
  ProductoId: number;
  Quantity: number;
  descripcion: string;
}

export interface DetalleMetodopago {
  Id: number;
  MetodoPagoId: number;
  Nombre: string;
  Usuarios: Array<Usuario>;
}

export interface DetalleOfertum {
  CalidadId: number;
  Cantidad: number;
  Id: number;
  OfertasId: number;
  ProductoId: number;
  UnidadMedidaId: number;
  Valor_Oferta: number;
  Valor_minimo: number;
  Valor_transaccion: number;
}

export interface DetalleTipoProducto {
  Cultivos: Array<Cultivo>;
  Descripcion: string;
  Id: number;
  Nombre: string;
  TipoProductoId: number;
}

export interface Enfermedade {
  Codigo: string;
  ControlPlagas: Array<ControlPlaga>;
  Descripcion: string;
  Fotos: Array<Foto>;
  Id: number;
  Nombre: string;
  NombreCientifico: string;
  TipoProductoId: number;
}

export interface Equipo {
  Id: number;
  Marca: string;
  Nombre: string;
  Receta: Array<Recetum>;
}

export interface Foto {
  Descripcion: string;
  EnfermedadesId: number;
  FechaCreacion: string;
  Hora: string;
  Id: number;
  Ruta: string;
  Titulo: string;
}

export interface Insumo {
  Descripcion: string;
  Fecha_Vencimiento: string;
  Id: number;
  Nombre: string;
  Receta: Array<Recetum>;
  Tipo_InsumoId: number;
  Tratamientos: Array<Tratamiento>;
  laboratorioId: number;
  lote_laboratorio: string;
}

export interface Laboratorio {
  Id: number;
  Insumos: Array<Insumo>;
  Nombre: string;
}

export interface LocalizacionUp {
  Barrio: string;
  Coordenadas: string;
  Direccion: string;
  DireccionAproximadaGps: string;
  Id: number;
  Latitud: number;
  Localidad: string;
  Longitud: number;
  ReferenciaLocalizacion: string;
  Sector: string;
  UnidadProductivaId: number;
  vereda: string;
}

export interface Lote {
  Area: number;
  Codigo: string;
  Cultivos: Array<Cultivo>;
  Id: number;
  Localizacion: string;
  Localizacion_Poligono: string;
  UnidadMedidaId: number;
  unidadproductivaId: number;
}

export interface MetodoPago {
  DetalleMetodopagos: Array<DetalleMetodopago>;
  Id: number;
  Nombre: string;
  Pagos: Array<Pago>;
}

export interface Notificacione {
  EstadoNotif: string;
  Fecha: string;
  Id: number;
  Mensaje: string;
  TypeNotificationId1: number;
}

export interface Oferta {
  CreatedOn: string;
  DetalleOferta: Array<DetalleOfertum>;
  EstadoOferta: number;
  EstadoOfertaId: number;
  Id: number;
  UpdatedOn: string;
  UsuarioId: number;
}

export interface Pago {
  ComprasPagos: Array<ComprasPago>;
  CreatedOn: string;
  Id: number;
  MetodoPagoId: number;
  Monto: number;
  Saldo: number;
  UpdatedOn: string;
}

export interface Produccion {
  CultivoId: number;
  FechaFin: string;
  FechaInicio: string;
  Id: number;
  produccionEstimada: number;
  unidadMedidaId: number;
}

export interface ProductCategorium {
  CategoriaId: number;
  Id: number;
  ProductoId: number;
}

export interface Producto {
  CalidadId: number;
  CategoriaId: number;
  CodigoUp: string;
  Descripcion: string;
  DetalleCompras: Array<DetalleCompra>;
  DetalleOferta: Array<DetalleOfertum>;
  FechaLimiteDisponibilidad: string;
  Id: number;
  Imagen: string;
  IsEnable: boolean;
  Precio: number;
  PrecioSpecial: number;
  ProductCategoria: Array<ProductCategorium>;
  Stock: number;
  cultivoId: number;
  nombre: string;
}

export interface Recetum {
  Dosis: number;
  EquipoId: number;
  Id: number;
  InsumoId: number;
  Modo_uso: string;
  UnidadId: number;
  nombre: string;
}

export interface Rol {
  Id: number;
  Nombre: string;
  Usuarios: Array<Usuario>;
}

export interface TipoInsumo {
  Id: number;
  Insumos: Array<Insumo>;
  Nombre: string;
}

export interface TipoProducto {
  DetalleTipoProductos: Array<DetalleTipoProducto>;
  Enfermedades: Array<Enfermedade>;
  Id: number;
  Nombre: string;
}

export interface Tratamiento {
  Categoria_InsumoId: number;
  ControlPlagas: Array<ControlPlaga>;
  Desc_Aplicacion: string;
  Desc_Formulacion: string;
  Id: number;
  IngredienteActivo: string;
  InsumoId: number;
  Modo_Accion: string;
  Nombre_Comercial: string;
  precioAproximado: number;
  proveedor: string;
}

export interface TypeNotification {
  Id: number;
  Nombre: string;
  Notificaciones: Array<Notificacione>;
  Sigla: string;
}

export interface UnidadMedida {
  ControlPlagas: Array<ControlPlaga>;
  Descripcion: string;
  DetalleOferta: Array<DetalleOfertum>;
  Id: number;
  Lotes: Array<Lote>;
  Produccions: Array<Produccion>;
  Receta: Array<Recetum>;
  Sigla: string;
  UnidadProductivas: Array<UnidadProductiva>;
}

export interface UnidadProductiva {
  Area: number;
  CiudadId: number;
  Codigo: string;
  Id: number;
  LocalizacionUps: Array<LocalizacionUp>;
  Lotes: Array<Lote>;
  UnidadMedidaId: number;
  UsuarioId: number;
  descripcion: string;
  nombre: string;
}

export interface Usuario {
  Apellidos: string;
  Compras: Array<Compra>;
  DetallemetodoPagoId: number;
  Email: string;
  EmailConfirmed: boolean;
  Estado: string;
  FechaRegistro: string;
  Fotopefil: string;
  Id: number;
  Identificacion: string;
  Nombre: string;
  Nro_movil: string;
  NumeroCuenta: string;
  Oferta: Array<Oferta>;
  PhoneNumber: string;
  PhoneNumberConfirmed: boolean;
  RolId: number;
  UnidadProductivas: Array<UnidadProductiva>;
  UserName: string;
}
