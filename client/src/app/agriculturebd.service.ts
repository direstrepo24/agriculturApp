import { Injectable } from '@angular/core';
import { Location } from '@angular/common';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';

import { environment } from '../environments/environment';
import { ODataClient } from './odata-client';
import * as models from './agriculturebd.model';

@Injectable()
export class AgriculturebdService {
  odata: ODataClient;
  basePath = environment.agriculturebd;

  constructor(private http: HttpClient) {
    this.odata = new ODataClient(this.http, this.basePath, { legacy: false, withCredentials: true });
  }

  getCalidads(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Calidads`, { filter, top, skip, orderby, count, expand });
  }

  createCalidad(calidad: models.Calidad | null) {
    return this.odata.post(`/Calidads`, calidad);
  }

  deleteCalidad(id: number | null) {
    return this.odata.delete(`/Calidads(${id})`, item => item.Id != id);
  }

  getCalidadById(id: number | null) {
    return this.odata.get(`/Calidads(${id})`);
  }

  updateCalidad(id: number | null, calidad: models.Calidad | null) {
    return this.odata.patch(`/Calidads(${id})`, calidad, item => item.Id == id);
  }

  getCategoria(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Categoria`, { filter, top, skip, orderby, count, expand });
  }

  createCategorium(categorium: models.Categorium | null) {
    return this.odata.post(`/Categoria`, categorium);
  }

  deleteCategorium(id: number | null) {
    return this.odata.delete(`/Categoria(${id})`, item => item.Id != id);
  }

  getCategoriumById(id: number | null) {
    return this.odata.get(`/Categoria(${id})`);
  }

  updateCategorium(id: number | null, categorium: models.Categorium | null) {
    return this.odata.patch(`/Categoria(${id})`, categorium, item => item.Id == id);
  }

  getCategoriaInsumos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/CategoriaInsumos`, { filter, top, skip, orderby, count, expand });
  }

  createCategoriaInsumo(categoriaInsumo: models.CategoriaInsumo | null) {
    return this.odata.post(`/CategoriaInsumos`, categoriaInsumo);
  }

  deleteCategoriaInsumo(id: number | null) {
    return this.odata.delete(`/CategoriaInsumos(${id})`, item => item.Id != id);
  }

  getCategoriaInsumoById(id: number | null) {
    return this.odata.get(`/CategoriaInsumos(${id})`);
  }

  updateCategoriaInsumo(id: number | null, categoriaInsumo: models.CategoriaInsumo | null) {
    return this.odata.patch(`/CategoriaInsumos(${id})`, categoriaInsumo, item => item.Id == id);
  }

  getCiudads(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Ciudads`, { filter, top, skip, orderby, count, expand });
  }

  createCiudad(ciudad: models.Ciudad | null) {
    return this.odata.post(`/Ciudads`, ciudad);
  }

  deleteCiudad(id: number | null) {
    return this.odata.delete(`/Ciudads(${id})`, item => item.Id != id);
  }

  getCiudadById(id: number | null) {
    return this.odata.get(`/Ciudads(${id})`);
  }

  updateCiudad(id: number | null, ciudad: models.Ciudad | null) {
    return this.odata.patch(`/Ciudads(${id})`, ciudad, item => item.Id == id);
  }

  getCompras(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Compras`, { filter, top, skip, orderby, count, expand });
  }

  createCompra(compra: models.Compra | null) {
    return this.odata.post(`/Compras`, compra);
  }

  deleteCompra(id: number | null) {
    return this.odata.delete(`/Compras(${id})`, item => item.Id != id);
  }

  getCompraById(id: number | null) {
    return this.odata.get(`/Compras(${id})`);
  }

  updateCompra(id: number | null, compra: models.Compra | null) {
    return this.odata.patch(`/Compras(${id})`, compra, item => item.Id == id);
  }

  getComprasPagos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/ComprasPagos`, { filter, top, skip, orderby, count, expand });
  }

  createComprasPago(comprasPago: models.ComprasPago | null) {
    return this.odata.post(`/ComprasPagos`, comprasPago);
  }

  deleteComprasPago(id: number | null) {
    return this.odata.delete(`/ComprasPagos(${id})`, item => item.Id != id);
  }

  getComprasPagoById(id: number | null) {
    return this.odata.get(`/ComprasPagos(${id})`);
  }

  updateComprasPago(id: number | null, comprasPago: models.ComprasPago | null) {
    return this.odata.patch(`/ComprasPagos(${id})`, comprasPago, item => item.Id == id);
  }

  getControlPlagas(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/ControlPlagas`, { filter, top, skip, orderby, count, expand });
  }

  createControlPlaga(controlPlaga: models.ControlPlaga | null) {
    return this.odata.post(`/ControlPlagas`, controlPlaga);
  }

  deleteControlPlaga(id: number | null) {
    return this.odata.delete(`/ControlPlagas(${id})`, item => item.Id != id);
  }

  getControlPlagaById(id: number | null) {
    return this.odata.get(`/ControlPlagas(${id})`);
  }

  updateControlPlaga(id: number | null, controlPlaga: models.ControlPlaga | null) {
    return this.odata.patch(`/ControlPlagas(${id})`, controlPlaga, item => item.Id == id);
  }

  getCultivos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Cultivos`, { filter, top, skip, orderby, count, expand });
  }

  createCultivo(cultivo: models.Cultivo | null) {
    return this.odata.post(`/Cultivos`, cultivo);
  }

  deleteCultivo(id: number | null) {
    return this.odata.delete(`/Cultivos(${id})`, item => item.Id != id);
  }

  getCultivoById(id: number | null) {
    return this.odata.get(`/Cultivos(${id})`);
  }

  updateCultivo(id: number | null, cultivo: models.Cultivo | null) {
    return this.odata.patch(`/Cultivos(${id})`, cultivo, item => item.Id == id);
  }

  getDepartamentos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Departamentos`, { filter, top, skip, orderby, count, expand });
  }

  createDepartamento(departamento: models.Departamento | null) {
    return this.odata.post(`/Departamentos`, departamento);
  }

  deleteDepartamento(id: number | null) {
    return this.odata.delete(`/Departamentos(${id})`, item => item.Id != id);
  }

  getDepartamentoById(id: number | null) {
    return this.odata.get(`/Departamentos(${id})`);
  }

  updateDepartamento(id: number | null, departamento: models.Departamento | null) {
    return this.odata.patch(`/Departamentos(${id})`, departamento, item => item.Id == id);
  }

  getDetalleCategoriaInsumos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/DetalleCategoriaInsumos`, { filter, top, skip, orderby, count, expand });
  }

  createDetalleCategoriaInsumo(detalleCategoriaInsumo: models.DetalleCategoriaInsumo | null) {
    return this.odata.post(`/DetalleCategoriaInsumos`, detalleCategoriaInsumo);
  }

  deleteDetalleCategoriaInsumo(id: number | null) {
    return this.odata.delete(`/DetalleCategoriaInsumos(${id})`, item => item.Id != id);
  }

  getDetalleCategoriaInsumoById(id: number | null) {
    return this.odata.get(`/DetalleCategoriaInsumos(${id})`);
  }

  updateDetalleCategoriaInsumo(id: number | null, detalleCategoriaInsumo: models.DetalleCategoriaInsumo | null) {
    return this.odata.patch(`/DetalleCategoriaInsumos(${id})`, detalleCategoriaInsumo, item => item.Id == id);
  }

  getDetalleCompras(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/DetalleCompras`, { filter, top, skip, orderby, count, expand });
  }

  createDetalleCompra(detalleCompra: models.DetalleCompra | null) {
    return this.odata.post(`/DetalleCompras`, detalleCompra);
  }

  deleteDetalleCompra(id: number | null) {
    return this.odata.delete(`/DetalleCompras(${id})`, item => item.Id != id);
  }

  getDetalleCompraById(id: number | null) {
    return this.odata.get(`/DetalleCompras(${id})`);
  }

  updateDetalleCompra(id: number | null, detalleCompra: models.DetalleCompra | null) {
    return this.odata.patch(`/DetalleCompras(${id})`, detalleCompra, item => item.Id == id);
  }

  getDetalleMetodopagos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/DetalleMetodopagos`, { filter, top, skip, orderby, count, expand });
  }

  createDetalleMetodopago(detalleMetodopago: models.DetalleMetodopago | null) {
    return this.odata.post(`/DetalleMetodopagos`, detalleMetodopago);
  }

  deleteDetalleMetodopago(id: number | null) {
    return this.odata.delete(`/DetalleMetodopagos(${id})`, item => item.Id != id);
  }

  getDetalleMetodopagoById(id: number | null) {
    return this.odata.get(`/DetalleMetodopagos(${id})`);
  }

  updateDetalleMetodopago(id: number | null, detalleMetodopago: models.DetalleMetodopago | null) {
    return this.odata.patch(`/DetalleMetodopagos(${id})`, detalleMetodopago, item => item.Id == id);
  }

  getDetalleOferta(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/DetalleOferta`, { filter, top, skip, orderby, count, expand });
  }

  createDetalleOfertum(detalleOfertum: models.DetalleOfertum | null) {
    return this.odata.post(`/DetalleOferta`, detalleOfertum);
  }

  deleteDetalleOfertum(id: number | null) {
    return this.odata.delete(`/DetalleOferta(${id})`, item => item.Id != id);
  }

  getDetalleOfertumById(id: number | null) {
    return this.odata.get(`/DetalleOferta(${id})`);
  }

  updateDetalleOfertum(id: number | null, detalleOfertum: models.DetalleOfertum | null) {
    return this.odata.patch(`/DetalleOferta(${id})`, detalleOfertum, item => item.Id == id);
  }

  getDetalleTipoProductos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/DetalleTipoProductos`, { filter, top, skip, orderby, count, expand });
  }

  createDetalleTipoProducto(detalleTipoProducto: models.DetalleTipoProducto | null) {
    return this.odata.post(`/DetalleTipoProductos`, detalleTipoProducto);
  }

  deleteDetalleTipoProducto(id: number | null) {
    return this.odata.delete(`/DetalleTipoProductos(${id})`, item => item.Id != id);
  }

  getDetalleTipoProductoById(id: number | null) {
    return this.odata.get(`/DetalleTipoProductos(${id})`);
  }

  updateDetalleTipoProducto(id: number | null, detalleTipoProducto: models.DetalleTipoProducto | null) {
    return this.odata.patch(`/DetalleTipoProductos(${id})`, detalleTipoProducto, item => item.Id == id);
  }

  getEnfermedades(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Enfermedades`, { filter, top, skip, orderby, count, expand });
  }

  createEnfermedade(enfermedade: models.Enfermedade | null) {
    return this.odata.post(`/Enfermedades`, enfermedade);
  }

  deleteEnfermedade(id: number | null) {
    return this.odata.delete(`/Enfermedades(${id})`, item => item.Id != id);
  }

  getEnfermedadeById(id: number | null) {
    return this.odata.get(`/Enfermedades(${id})`);
  }

  updateEnfermedade(id: number | null, enfermedade: models.Enfermedade | null) {
    return this.odata.patch(`/Enfermedades(${id})`, enfermedade, item => item.Id == id);
  }

  getEquipos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Equipos`, { filter, top, skip, orderby, count, expand });
  }

  createEquipo(equipo: models.Equipo | null) {
    return this.odata.post(`/Equipos`, equipo);
  }

  deleteEquipo(id: number | null) {
    return this.odata.delete(`/Equipos(${id})`, item => item.Id != id);
  }

  getEquipoById(id: number | null) {
    return this.odata.get(`/Equipos(${id})`);
  }

  updateEquipo(id: number | null, equipo: models.Equipo | null) {
    return this.odata.patch(`/Equipos(${id})`, equipo, item => item.Id == id);
  }

  getFotos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Fotos`, { filter, top, skip, orderby, count, expand });
  }

  createFoto(foto: models.Foto | null) {
    return this.odata.post(`/Fotos`, foto);
  }

  deleteFoto(id: number | null) {
    return this.odata.delete(`/Fotos(${id})`, item => item.Id != id);
  }

  getFotoById(id: number | null) {
    return this.odata.get(`/Fotos(${id})`);
  }

  updateFoto(id: number | null, foto: models.Foto | null) {
    return this.odata.patch(`/Fotos(${id})`, foto, item => item.Id == id);
  }

  getInsumos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Insumos`, { filter, top, skip, orderby, count, expand });
  }

  createInsumo(insumo: models.Insumo | null) {
    return this.odata.post(`/Insumos`, insumo);
  }

  deleteInsumo(id: number | null) {
    return this.odata.delete(`/Insumos(${id})`, item => item.Id != id);
  }

  getInsumoById(id: number | null) {
    return this.odata.get(`/Insumos(${id})`);
  }

  updateInsumo(id: number | null, insumo: models.Insumo | null) {
    return this.odata.patch(`/Insumos(${id})`, insumo, item => item.Id == id);
  }

  getLaboratorios(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Laboratorios`, { filter, top, skip, orderby, count, expand });
  }

  createLaboratorio(laboratorio: models.Laboratorio | null) {
    return this.odata.post(`/Laboratorios`, laboratorio);
  }

  deleteLaboratorio(id: number | null) {
    return this.odata.delete(`/Laboratorios(${id})`, item => item.Id != id);
  }

  getLaboratorioById(id: number | null) {
    return this.odata.get(`/Laboratorios(${id})`);
  }

  updateLaboratorio(id: number | null, laboratorio: models.Laboratorio | null) {
    return this.odata.patch(`/Laboratorios(${id})`, laboratorio, item => item.Id == id);
  }

  getLocalizacionUps(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/LocalizacionUps`, { filter, top, skip, orderby, count, expand });
  }

  createLocalizacionUp(localizacionUp: models.LocalizacionUp | null) {
    return this.odata.post(`/LocalizacionUps`, localizacionUp);
  }

  deleteLocalizacionUp(id: number | null) {
    return this.odata.delete(`/LocalizacionUps(${id})`, item => item.Id != id);
  }

  getLocalizacionUpById(id: number | null) {
    return this.odata.get(`/LocalizacionUps(${id})`);
  }

  updateLocalizacionUp(id: number | null, localizacionUp: models.LocalizacionUp | null) {
    return this.odata.patch(`/LocalizacionUps(${id})`, localizacionUp, item => item.Id == id);
  }

  getLotes(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Lotes`, { filter, top, skip, orderby, count, expand });
  }

  createLote(lote: models.Lote | null) {
    return this.odata.post(`/Lotes`, lote);
  }

  deleteLote(id: number | null) {
    return this.odata.delete(`/Lotes(${id})`, item => item.Id != id);
  }

  getLoteById(id: number | null) {
    return this.odata.get(`/Lotes(${id})`);
  }

  updateLote(id: number | null, lote: models.Lote | null) {
    return this.odata.patch(`/Lotes(${id})`, lote, item => item.Id == id);
  }

  getMetodoPagos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/MetodoPagos`, { filter, top, skip, orderby, count, expand });
  }

  createMetodoPago(metodoPago: models.MetodoPago | null) {
    return this.odata.post(`/MetodoPagos`, metodoPago);
  }

  deleteMetodoPago(id: number | null) {
    return this.odata.delete(`/MetodoPagos(${id})`, item => item.Id != id);
  }

  getMetodoPagoById(id: number | null) {
    return this.odata.get(`/MetodoPagos(${id})`);
  }

  updateMetodoPago(id: number | null, metodoPago: models.MetodoPago | null) {
    return this.odata.patch(`/MetodoPagos(${id})`, metodoPago, item => item.Id == id);
  }

  getNotificaciones(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Notificaciones`, { filter, top, skip, orderby, count, expand });
  }

  createNotificacione(notificacione: models.Notificacione | null) {
    return this.odata.post(`/Notificaciones`, notificacione);
  }

  deleteNotificacione(id: number | null) {
    return this.odata.delete(`/Notificaciones(${id})`, item => item.Id != id);
  }

  getNotificacioneById(id: number | null) {
    return this.odata.get(`/Notificaciones(${id})`);
  }

  updateNotificacione(id: number | null, notificacione: models.Notificacione | null) {
    return this.odata.patch(`/Notificaciones(${id})`, notificacione, item => item.Id == id);
  }

  getOferta(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Oferta`, { filter, top, skip, orderby, count, expand });
  }

  createOferta(oferta: models.Oferta | null) {
    return this.odata.post(`/Oferta`, oferta);
  }

  deleteOferta(id: number | null) {
    return this.odata.delete(`/Oferta(${id})`, item => item.Id != id);
  }

  getOfertaById(id: number | null) {
    return this.odata.get(`/Oferta(${id})`);
  }

  updateOferta(id: number | null, oferta: models.Oferta | null) {
    return this.odata.patch(`/Oferta(${id})`, oferta, item => item.Id == id);
  }

  getPagos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Pagos`, { filter, top, skip, orderby, count, expand });
  }

  createPago(pago: models.Pago | null) {
    return this.odata.post(`/Pagos`, pago);
  }

  deletePago(id: number | null) {
    return this.odata.delete(`/Pagos(${id})`, item => item.Id != id);
  }

  getPagoById(id: number | null) {
    return this.odata.get(`/Pagos(${id})`);
  }

  updatePago(id: number | null, pago: models.Pago | null) {
    return this.odata.patch(`/Pagos(${id})`, pago, item => item.Id == id);
  }

  getProduccions(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Produccions`, { filter, top, skip, orderby, count, expand });
  }

  createProduccion(produccion: models.Produccion | null) {
    return this.odata.post(`/Produccions`, produccion);
  }

  deleteProduccion(id: number | null) {
    return this.odata.delete(`/Produccions(${id})`, item => item.Id != id);
  }

  getProduccionById(id: number | null) {
    return this.odata.get(`/Produccions(${id})`);
  }

  updateProduccion(id: number | null, produccion: models.Produccion | null) {
    return this.odata.patch(`/Produccions(${id})`, produccion, item => item.Id == id);
  }

  getProductCategoria(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/ProductCategoria`, { filter, top, skip, orderby, count, expand });
  }

  createProductCategorium(productCategorium: models.ProductCategorium | null) {
    return this.odata.post(`/ProductCategoria`, productCategorium);
  }

  deleteProductCategorium(id: number | null) {
    return this.odata.delete(`/ProductCategoria(${id})`, item => item.Id != id);
  }

  getProductCategoriumById(id: number | null) {
    return this.odata.get(`/ProductCategoria(${id})`);
  }

  updateProductCategorium(id: number | null, productCategorium: models.ProductCategorium | null) {
    return this.odata.patch(`/ProductCategoria(${id})`, productCategorium, item => item.Id == id);
  }

  getProductos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Productos`, { filter, top, skip, orderby, count, expand });
  }

  createProducto(producto: models.Producto | null) {
    return this.odata.post(`/Productos`, producto);
  }

  deleteProducto(id: number | null) {
    return this.odata.delete(`/Productos(${id})`, item => item.Id != id);
  }

  getProductoById(id: number | null) {
    return this.odata.get(`/Productos(${id})`);
  }

  updateProducto(id: number | null, producto: models.Producto | null) {
    return this.odata.patch(`/Productos(${id})`, producto, item => item.Id == id);
  }

  getReceta(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Receta`, { filter, top, skip, orderby, count, expand });
  }

  createRecetum(recetum: models.Recetum | null) {
    return this.odata.post(`/Receta`, recetum);
  }

  deleteRecetum(id: number | null) {
    return this.odata.delete(`/Receta(${id})`, item => item.Id != id);
  }

  getRecetumById(id: number | null) {
    return this.odata.get(`/Receta(${id})`);
  }

  updateRecetum(id: number | null, recetum: models.Recetum | null) {
    return this.odata.patch(`/Receta(${id})`, recetum, item => item.Id == id);
  }

  getRols(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Rols`, { filter, top, skip, orderby, count, expand });
  }

  createRol(rol: models.Rol | null) {
    return this.odata.post(`/Rols`, rol);
  }

  deleteRol(id: number | null) {
    return this.odata.delete(`/Rols(${id})`, item => item.Id != id);
  }

  getRolById(id: number | null) {
    return this.odata.get(`/Rols(${id})`);
  }

  updateRol(id: number | null, rol: models.Rol | null) {
    return this.odata.patch(`/Rols(${id})`, rol, item => item.Id == id);
  }

  getTipoInsumos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/TipoInsumos`, { filter, top, skip, orderby, count, expand });
  }

  createTipoInsumo(tipoInsumo: models.TipoInsumo | null) {
    return this.odata.post(`/TipoInsumos`, tipoInsumo);
  }

  deleteTipoInsumo(id: number | null) {
    return this.odata.delete(`/TipoInsumos(${id})`, item => item.Id != id);
  }

  getTipoInsumoById(id: number | null) {
    return this.odata.get(`/TipoInsumos(${id})`);
  }

  updateTipoInsumo(id: number | null, tipoInsumo: models.TipoInsumo | null) {
    return this.odata.patch(`/TipoInsumos(${id})`, tipoInsumo, item => item.Id == id);
  }

  getTipoProductos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/TipoProductos`, { filter, top, skip, orderby, count, expand });
  }

  createTipoProducto(tipoProducto: models.TipoProducto | null) {
    return this.odata.post(`/TipoProductos`, tipoProducto);
  }

  deleteTipoProducto(id: number | null) {
    return this.odata.delete(`/TipoProductos(${id})`, item => item.Id != id);
  }

  getTipoProductoById(id: number | null) {
    return this.odata.get(`/TipoProductos(${id})`);
  }

  updateTipoProducto(id: number | null, tipoProducto: models.TipoProducto | null) {
    return this.odata.patch(`/TipoProductos(${id})`, tipoProducto, item => item.Id == id);
  }

  getTratamientos(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Tratamientos`, { filter, top, skip, orderby, count, expand });
  }

  createTratamiento(tratamiento: models.Tratamiento | null) {
    return this.odata.post(`/Tratamientos`, tratamiento);
  }

  deleteTratamiento(id: number | null) {
    return this.odata.delete(`/Tratamientos(${id})`, item => item.Id != id);
  }

  getTratamientoById(id: number | null) {
    return this.odata.get(`/Tratamientos(${id})`);
  }

  updateTratamiento(id: number | null, tratamiento: models.Tratamiento | null) {
    return this.odata.patch(`/Tratamientos(${id})`, tratamiento, item => item.Id == id);
  }

  getTypeNotifications(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/TypeNotifications`, { filter, top, skip, orderby, count, expand });
  }

  createTypeNotification(typeNotification: models.TypeNotification | null) {
    return this.odata.post(`/TypeNotifications`, typeNotification);
  }

  deleteTypeNotification(id: number | null) {
    return this.odata.delete(`/TypeNotifications(${id})`, item => item.Id != id);
  }

  getTypeNotificationById(id: number | null) {
    return this.odata.get(`/TypeNotifications(${id})`);
  }

  updateTypeNotification(id: number | null, typeNotification: models.TypeNotification | null) {
    return this.odata.patch(`/TypeNotifications(${id})`, typeNotification, item => item.Id == id);
  }

  getUnidadMedidas(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/UnidadMedidas`, { filter, top, skip, orderby, count, expand });
  }

  createUnidadMedida(unidadMedida: models.UnidadMedida | null) {
    return this.odata.post(`/UnidadMedidas`, unidadMedida);
  }

  deleteUnidadMedida(id: number | null) {
    return this.odata.delete(`/UnidadMedidas(${id})`, item => item.Id != id);
  }

  getUnidadMedidaById(id: number | null) {
    return this.odata.get(`/UnidadMedidas(${id})`);
  }

  updateUnidadMedida(id: number | null, unidadMedida: models.UnidadMedida | null) {
    return this.odata.patch(`/UnidadMedidas(${id})`, unidadMedida, item => item.Id == id);
  }

  getUnidadProductivas(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/UnidadProductivas`, { filter, top, skip, orderby, count, expand });
  }

  createUnidadProductiva(unidadProductiva: models.UnidadProductiva | null) {
    return this.odata.post(`/UnidadProductivas`, unidadProductiva);
  }

  deleteUnidadProductiva(id: number | null) {
    return this.odata.delete(`/UnidadProductivas(${id})`, item => item.Id != id);
  }

  getUnidadProductivaById(id: number | null) {
    return this.odata.get(`/UnidadProductivas(${id})`);
  }

  updateUnidadProductiva(id: number | null, unidadProductiva: models.UnidadProductiva | null) {
    return this.odata.patch(`/UnidadProductivas(${id})`, unidadProductiva, item => item.Id == id);
  }

  getUsuarios(filter: string | null, top: number | null, skip: number | null, orderby: string | null, count: boolean | null, expand: string | null) {
    return this.odata.get(`/Usuarios`, { filter, top, skip, orderby, count, expand });
  }

  createUsuario(usuario: models.Usuario | null) {
    return this.odata.post(`/Usuarios`, usuario);
  }

  deleteUsuario(id: number | null) {
    return this.odata.delete(`/Usuarios(${id})`, item => item.Id != id);
  }

  getUsuarioById(id: number | null) {
    return this.odata.get(`/Usuarios(${id})`);
  }

  updateUsuario(id: number | null, usuario: models.Usuario | null) {
    return this.odata.patch(`/Usuarios(${id})`, usuario, item => item.Id == id);
  }
}
