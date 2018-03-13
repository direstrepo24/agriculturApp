import { ModuleWithProviders } from '@angular/core';
import { Routes, RouterModule, ActivatedRoute } from '@angular/router';

import { PageTitleComponent } from './app.component';
import { CalidadsComponent } from './calidads/calidads.component';
import { AddCalidadComponent } from './add-calidad/add-calidad.component';
import { EditCalidadComponent } from './edit-calidad/edit-calidad.component';
import { CategoriaInsumosComponent } from './categoria-insumos/categoria-insumos.component';
import { AddCategoriaInsumoComponent } from './add-categoria-insumo/add-categoria-insumo.component';
import { EditCategoriaInsumoComponent } from './edit-categoria-insumo/edit-categoria-insumo.component';
import { CategoriaComponent } from './categoria/categoria.component';
import { AddCategoriumComponent } from './add-categorium/add-categorium.component';
import { EditCategoriumComponent } from './edit-categorium/edit-categorium.component';
import { CiudadsComponent } from './ciudads/ciudads.component';
import { AddCiudadComponent } from './add-ciudad/add-ciudad.component';
import { EditCiudadComponent } from './edit-ciudad/edit-ciudad.component';
import { ComprasComponent } from './compras/compras.component';
import { AddCompraComponent } from './add-compra/add-compra.component';
import { EditCompraComponent } from './edit-compra/edit-compra.component';
import { ComprasPagosComponent } from './compras-pagos/compras-pagos.component';
import { AddComprasPagoComponent } from './add-compras-pago/add-compras-pago.component';
import { EditComprasPagoComponent } from './edit-compras-pago/edit-compras-pago.component';
import { ControlPlagasComponent } from './control-plagas/control-plagas.component';
import { AddControlPlagaComponent } from './add-control-plaga/add-control-plaga.component';
import { EditControlPlagaComponent } from './edit-control-plaga/edit-control-plaga.component';
import { CultivosComponent } from './cultivos/cultivos.component';
import { AddCultivoComponent } from './add-cultivo/add-cultivo.component';
import { EditCultivoComponent } from './edit-cultivo/edit-cultivo.component';
import { DepartamentosComponent } from './departamentos/departamentos.component';
import { AddDepartamentoComponent } from './add-departamento/add-departamento.component';
import { EditDepartamentoComponent } from './edit-departamento/edit-departamento.component';
import { DetalleCategoriaInsumosComponent } from './detalle-categoria-insumos/detalle-categoria-insumos.component';
import { AddDetalleCategoriaInsumoComponent } from './add-detalle-categoria-insumo/add-detalle-categoria-insumo.component';
import { EditDetalleCategoriaInsumoComponent } from './edit-detalle-categoria-insumo/edit-detalle-categoria-insumo.component';
import { DetalleComprasComponent } from './detalle-compras/detalle-compras.component';
import { AddDetalleCompraComponent } from './add-detalle-compra/add-detalle-compra.component';
import { EditDetalleCompraComponent } from './edit-detalle-compra/edit-detalle-compra.component';
import { DetalleMetodopagosComponent } from './detalle-metodopagos/detalle-metodopagos.component';
import { AddDetalleMetodopagoComponent } from './add-detalle-metodopago/add-detalle-metodopago.component';
import { EditDetalleMetodopagoComponent } from './edit-detalle-metodopago/edit-detalle-metodopago.component';
import { DetalleOfertaComponent } from './detalle-oferta/detalle-oferta.component';
import { AddDetalleOfertumComponent } from './add-detalle-ofertum/add-detalle-ofertum.component';
import { EditDetalleOfertumComponent } from './edit-detalle-ofertum/edit-detalle-ofertum.component';
import { DetalleTipoProductosComponent } from './detalle-tipo-productos/detalle-tipo-productos.component';
import { AddDetalleTipoProductoComponent } from './add-detalle-tipo-producto/add-detalle-tipo-producto.component';
import { EditDetalleTipoProductoComponent } from './edit-detalle-tipo-producto/edit-detalle-tipo-producto.component';
import { EnfermedadesComponent } from './enfermedades/enfermedades.component';
import { AddEnfermedadeComponent } from './add-enfermedade/add-enfermedade.component';
import { EditEnfermedadeComponent } from './edit-enfermedade/edit-enfermedade.component';
import { EquiposComponent } from './equipos/equipos.component';
import { AddEquipoComponent } from './add-equipo/add-equipo.component';
import { EditEquipoComponent } from './edit-equipo/edit-equipo.component';
import { FotosComponent } from './fotos/fotos.component';
import { AddFotoComponent } from './add-foto/add-foto.component';
import { EditFotoComponent } from './edit-foto/edit-foto.component';
import { InsumosComponent } from './insumos/insumos.component';
import { AddInsumoComponent } from './add-insumo/add-insumo.component';
import { EditInsumoComponent } from './edit-insumo/edit-insumo.component';
import { LaboratoriosComponent } from './laboratorios/laboratorios.component';
import { AddLaboratorioComponent } from './add-laboratorio/add-laboratorio.component';
import { EditLaboratorioComponent } from './edit-laboratorio/edit-laboratorio.component';
import { LocalizacionUpsComponent } from './localizacion-ups/localizacion-ups.component';
import { AddLocalizacionUpComponent } from './add-localizacion-up/add-localizacion-up.component';
import { EditLocalizacionUpComponent } from './edit-localizacion-up/edit-localizacion-up.component';
import { LotesComponent } from './lotes/lotes.component';
import { AddLoteComponent } from './add-lote/add-lote.component';
import { EditLoteComponent } from './edit-lote/edit-lote.component';
import { MetodoPagosComponent } from './metodo-pagos/metodo-pagos.component';
import { AddMetodoPagoComponent } from './add-metodo-pago/add-metodo-pago.component';
import { EditMetodoPagoComponent } from './edit-metodo-pago/edit-metodo-pago.component';
import { NotificacionesComponent } from './notificaciones/notificaciones.component';
import { AddNotificacioneComponent } from './add-notificacione/add-notificacione.component';
import { EditNotificacioneComponent } from './edit-notificacione/edit-notificacione.component';
import { OfertaComponent } from './oferta/oferta.component';
import { AddOfertaComponent } from './add-oferta/add-oferta.component';
import { EditOfertaComponent } from './edit-oferta/edit-oferta.component';
import { PagosComponent } from './pagos/pagos.component';
import { AddPagoComponent } from './add-pago/add-pago.component';
import { EditPagoComponent } from './edit-pago/edit-pago.component';
import { ProduccionsComponent } from './produccions/produccions.component';
import { AddProduccionComponent } from './add-produccion/add-produccion.component';
import { EditProduccionComponent } from './edit-produccion/edit-produccion.component';
import { ProductCategoriaComponent } from './product-categoria/product-categoria.component';
import { AddProductCategoriumComponent } from './add-product-categorium/add-product-categorium.component';
import { EditProductCategoriumComponent } from './edit-product-categorium/edit-product-categorium.component';
import { ProductosComponent } from './productos/productos.component';
import { AddProductoComponent } from './add-producto/add-producto.component';
import { EditProductoComponent } from './edit-producto/edit-producto.component';
import { RecetaComponent } from './receta/receta.component';
import { AddRecetumComponent } from './add-recetum/add-recetum.component';
import { EditRecetumComponent } from './edit-recetum/edit-recetum.component';
import { RolsComponent } from './rols/rols.component';
import { AddRolComponent } from './add-rol/add-rol.component';
import { EditRolComponent } from './edit-rol/edit-rol.component';
import { TipoInsumosComponent } from './tipo-insumos/tipo-insumos.component';
import { AddTipoInsumoComponent } from './add-tipo-insumo/add-tipo-insumo.component';
import { EditTipoInsumoComponent } from './edit-tipo-insumo/edit-tipo-insumo.component';
import { TipoProductosComponent } from './tipo-productos/tipo-productos.component';
import { AddTipoProductoComponent } from './add-tipo-producto/add-tipo-producto.component';
import { EditTipoProductoComponent } from './edit-tipo-producto/edit-tipo-producto.component';
import { TratamientosComponent } from './tratamientos/tratamientos.component';
import { AddTratamientoComponent } from './add-tratamiento/add-tratamiento.component';
import { EditTratamientoComponent } from './edit-tratamiento/edit-tratamiento.component';
import { TypeNotificationsComponent } from './type-notifications/type-notifications.component';
import { AddTypeNotificationComponent } from './add-type-notification/add-type-notification.component';
import { EditTypeNotificationComponent } from './edit-type-notification/edit-type-notification.component';
import { UnidadMedidasComponent } from './unidad-medidas/unidad-medidas.component';
import { AddUnidadMedidaComponent } from './add-unidad-medida/add-unidad-medida.component';
import { EditUnidadMedidaComponent } from './edit-unidad-medida/edit-unidad-medida.component';
import { UnidadProductivasComponent } from './unidad-productivas/unidad-productivas.component';
import { AddUnidadProductivaComponent } from './add-unidad-productiva/add-unidad-productiva.component';
import { EditUnidadProductivaComponent } from './edit-unidad-productiva/edit-unidad-productiva.component';
import { UsuariosComponent } from './usuarios/usuarios.component';
import { AddUsuarioComponent } from './add-usuario/add-usuario.component';
import { EditUsuarioComponent } from './edit-usuario/edit-usuario.component';
import { LoginComponent } from './login/login.component';
import { UsersComponent } from './users/users.component';
import { RolesComponent } from './roles/roles.component';
import { AddRoleComponent } from './add-role/add-role.component';
import { EditUserComponent } from './edit-user/edit-user.component';
import { ProfileComponent } from './profile/profile.component';
import { UnauthorizedComponent } from './unauthorized/unauthorized.component';
import { AddUserComponent } from './add-user/add-user.component';
import { RegisterUserComponent } from './register-user/register-user.component';
import { FilterComponent } from './filter/filter.component';

import { SecurityService } from './security.service';
import { AuthGuard } from './auth.guard';
export const pageRoutes: Routes = [
  {
    path: 'calidads',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: CalidadsComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Calidads',
        }
      }
    ]
  },
  {
    path: 'add-calidad',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddCalidadComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Calidad',
        }
      }
    ]
  },
  {
    path: 'edit-calidad',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditCalidadComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Calidad',
        }
      }
    ]
  },
  {
    path: 'categoria-insumos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: CategoriaInsumosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Categoria Insumos',
        }
      }
    ]
  },
  {
    path: 'add-categoria-insumo',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddCategoriaInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Categoria Insumo',
        }
      }
    ]
  },
  {
    path: 'edit-categoria-insumo',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditCategoriaInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Categoria Insumo',
        }
      }
    ]
  },
  {
    path: 'categoria',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: CategoriaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Categoria',
        }
      }
    ]
  },
  {
    path: 'add-categorium',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddCategoriumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Categorium',
        }
      }
    ]
  },
  {
    path: 'edit-categorium',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditCategoriumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Categorium',
        }
      }
    ]
  },
  {
    path: 'ciudads',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: CiudadsComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Ciudads',
        }
      }
    ]
  },
  {
    path: 'add-ciudad',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddCiudadComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Ciudad',
        }
      }
    ]
  },
  {
    path: 'edit-ciudad',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditCiudadComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Ciudad',
        }
      }
    ]
  },
  {
    path: 'compras',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: ComprasComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Compras',
        }
      }
    ]
  },
  {
    path: 'add-compra',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddCompraComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Compra',
        }
      }
    ]
  },
  {
    path: 'edit-compra',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditCompraComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Compra',
        }
      }
    ]
  },
  {
    path: 'compras-pagos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: ComprasPagosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Compras Pagos',
        }
      }
    ]
  },
  {
    path: 'add-compras-pago',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddComprasPagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Compras Pago',
        }
      }
    ]
  },
  {
    path: 'edit-compras-pago',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditComprasPagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Compras Pago',
        }
      }
    ]
  },
  {
    path: 'control-plagas',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: ControlPlagasComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Control Plagas',
        }
      }
    ]
  },
  {
    path: 'add-control-plaga',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddControlPlagaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Control Plaga',
        }
      }
    ]
  },
  {
    path: 'edit-control-plaga',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditControlPlagaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Control Plaga',
        }
      }
    ]
  },
  {
    path: 'cultivos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: CultivosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Cultivos',
        }
      }
    ]
  },
  {
    path: 'add-cultivo',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddCultivoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Cultivo',
        }
      }
    ]
  },
  {
    path: 'edit-cultivo',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditCultivoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Cultivo',
        }
      }
    ]
  },
  {
    path: 'departamentos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: DepartamentosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Departamentos',
        }
      }
    ]
  },
  {
    path: 'add-departamento',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddDepartamentoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Departamento',
        }
      }
    ]
  },
  {
    path: 'edit-departamento',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditDepartamentoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Departamento',
        }
      }
    ]
  },
  {
    path: 'detalle-categoria-insumos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: DetalleCategoriaInsumosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Detalle Categoria Insumos',
        }
      }
    ]
  },
  {
    path: 'add-detalle-categoria-insumo',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddDetalleCategoriaInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Detalle Categoria Insumo',
        }
      }
    ]
  },
  {
    path: 'edit-detalle-categoria-insumo',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditDetalleCategoriaInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Detalle Categoria Insumo',
        }
      }
    ]
  },
  {
    path: 'detalle-compras',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: DetalleComprasComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Detalle Compras',
        }
      }
    ]
  },
  {
    path: 'add-detalle-compra',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddDetalleCompraComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Detalle Compra',
        }
      }
    ]
  },
  {
    path: 'edit-detalle-compra',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditDetalleCompraComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Detalle Compra',
        }
      }
    ]
  },
  {
    path: 'detalle-metodopagos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: DetalleMetodopagosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Detalle Metodopagos',
        }
      }
    ]
  },
  {
    path: 'add-detalle-metodopago',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddDetalleMetodopagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Detalle Metodopago',
        }
      }
    ]
  },
  {
    path: 'edit-detalle-metodopago',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditDetalleMetodopagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Detalle Metodopago',
        }
      }
    ]
  },
  {
    path: 'detalle-oferta',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: DetalleOfertaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Detalle Oferta',
        }
      }
    ]
  },
  {
    path: 'add-detalle-ofertum',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddDetalleOfertumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Detalle Ofertum',
        }
      }
    ]
  },
  {
    path: 'edit-detalle-ofertum',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditDetalleOfertumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Detalle Ofertum',
        }
      }
    ]
  },
  {
    path: 'detalle-tipo-productos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: DetalleTipoProductosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Detalle Tipo Productos',
        }
      }
    ]
  },
  {
    path: 'add-detalle-tipo-producto',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddDetalleTipoProductoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Detalle Tipo Producto',
        }
      }
    ]
  },
  {
    path: 'edit-detalle-tipo-producto',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditDetalleTipoProductoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Detalle Tipo Producto',
        }
      }
    ]
  },
  {
    path: 'enfermedades',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EnfermedadesComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Enfermedades',
        }
      }
    ]
  },
  {
    path: 'add-enfermedade',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddEnfermedadeComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Enfermedade',
        }
      }
    ]
  },
  {
    path: 'edit-enfermedade',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditEnfermedadeComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Enfermedade',
        }
      }
    ]
  },
  {
    path: 'equipos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EquiposComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Equipos',
        }
      }
    ]
  },
  {
    path: 'add-equipo',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddEquipoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Equipo',
        }
      }
    ]
  },
  {
    path: 'edit-equipo',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditEquipoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Equipo',
        }
      }
    ]
  },
  {
    path: 'fotos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: FotosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Fotos',
        }
      }
    ]
  },
  {
    path: 'add-foto',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddFotoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Foto',
        }
      }
    ]
  },
  {
    path: 'edit-foto',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditFotoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Foto',
        }
      }
    ]
  },
  {
    path: 'insumos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: InsumosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Insumos',
        }
      }
    ]
  },
  {
    path: 'add-insumo',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Insumo',
        }
      }
    ]
  },
  {
    path: 'edit-insumo',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Insumo',
        }
      }
    ]
  },
  {
    path: 'laboratorios',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: LaboratoriosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Laboratorios',
        }
      }
    ]
  },
  {
    path: 'add-laboratorio',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddLaboratorioComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Laboratorio',
        }
      }
    ]
  },
  {
    path: 'edit-laboratorio',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditLaboratorioComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Laboratorio',
        }
      }
    ]
  },
  {
    path: 'localizacion-ups',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: LocalizacionUpsComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Localizacion Ups',
        }
      }
    ]
  },
  {
    path: 'add-localizacion-up',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddLocalizacionUpComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Localizacion Up',
        }
      }
    ]
  },
  {
    path: 'edit-localizacion-up',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditLocalizacionUpComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Localizacion Up',
        }
      }
    ]
  },
  {
    path: 'lotes',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: LotesComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Lotes',
        }
      }
    ]
  },
  {
    path: 'add-lote',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddLoteComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Lote',
        }
      }
    ]
  },
  {
    path: 'edit-lote',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditLoteComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Lote',
        }
      }
    ]
  },
  {
    path: 'metodo-pagos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: MetodoPagosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Metodo Pagos',
        }
      }
    ]
  },
  {
    path: 'add-metodo-pago',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddMetodoPagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Metodo Pago',
        }
      }
    ]
  },
  {
    path: 'edit-metodo-pago',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditMetodoPagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Metodo Pago',
        }
      }
    ]
  },
  {
    path: 'notificaciones',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: NotificacionesComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Notificaciones',
        }
      }
    ]
  },
  {
    path: 'add-notificacione',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddNotificacioneComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Notificacione',
        }
      }
    ]
  },
  {
    path: 'edit-notificacione',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditNotificacioneComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Notificacione',
        }
      }
    ]
  },
  {
    path: 'oferta',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: OfertaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Oferta',
        }
      }
    ]
  },
  {
    path: 'add-oferta',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddOfertaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Oferta',
        }
      }
    ]
  },
  {
    path: 'edit-oferta',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditOfertaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Oferta',
        }
      }
    ]
  },
  {
    path: 'pagos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: PagosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Pagos',
        }
      }
    ]
  },
  {
    path: 'add-pago',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddPagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Pago',
        }
      }
    ]
  },
  {
    path: 'edit-pago',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditPagoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Pago',
        }
      }
    ]
  },
  {
    path: 'produccions',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: ProduccionsComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Produccions',
        }
      }
    ]
  },
  {
    path: 'add-produccion',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddProduccionComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Produccion',
        }
      }
    ]
  },
  {
    path: 'edit-produccion',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditProduccionComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Produccion',
        }
      }
    ]
  },
  {
    path: 'product-categoria',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: ProductCategoriaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Product Categoria',
        }
      }
    ]
  },
  {
    path: 'add-product-categorium',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddProductCategoriumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Product Categorium',
        }
      }
    ]
  },
  {
    path: 'edit-product-categorium',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditProductCategoriumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Product Categorium',
        }
      }
    ]
  },
  {
    path: 'productos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: ProductosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Productos',
        }
      }
    ]
  },
  {
    path: 'add-producto',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddProductoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Producto',
        }
      }
    ]
  },
  {
    path: 'edit-producto',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditProductoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Producto',
        }
      }
    ]
  },
  {
    path: 'receta',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: RecetaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Receta',
        }
      }
    ]
  },
  {
    path: 'add-recetum',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddRecetumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Recetum',
        }
      }
    ]
  },
  {
    path: 'edit-recetum',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditRecetumComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Recetum',
        }
      }
    ]
  },
  {
    path: 'rols',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: RolsComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Rols',
        }
      }
    ]
  },
  {
    path: 'add-rol',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddRolComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Rol',
        }
      }
    ]
  },
  {
    path: 'edit-rol',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditRolComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Rol',
        }
      }
    ]
  },
  {
    path: 'tipo-insumos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: TipoInsumosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Tipo Insumos',
        }
      }
    ]
  },
  {
    path: 'add-tipo-insumo',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddTipoInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Tipo Insumo',
        }
      }
    ]
  },
  {
    path: 'edit-tipo-insumo',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditTipoInsumoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Tipo Insumo',
        }
      }
    ]
  },
  {
    path: 'tipo-productos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: TipoProductosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Tipo Productos',
        }
      }
    ]
  },
  {
    path: 'add-tipo-producto',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddTipoProductoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Tipo Producto',
        }
      }
    ]
  },
  {
    path: 'edit-tipo-producto',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditTipoProductoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Tipo Producto',
        }
      }
    ]
  },
  {
    path: 'tratamientos',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: TratamientosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Tratamientos',
        }
      }
    ]
  },
  {
    path: 'add-tratamiento',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddTratamientoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Tratamiento',
        }
      }
    ]
  },
  {
    path: 'edit-tratamiento',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditTratamientoComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Tratamiento',
        }
      }
    ]
  },
  {
    path: 'type-notifications',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: TypeNotificationsComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Type Notifications',
        }
      }
    ]
  },
  {
    path: 'add-type-notification',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddTypeNotificationComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Type Notification',
        }
      }
    ]
  },
  {
    path: 'edit-type-notification',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditTypeNotificationComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Type Notification',
        }
      }
    ]
  },
  {
    path: 'unidad-medidas',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: UnidadMedidasComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Unidad Medidas',
        }
      }
    ]
  },
  {
    path: 'add-unidad-medida',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddUnidadMedidaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Unidad Medida',
        }
      }
    ]
  },
  {
    path: 'edit-unidad-medida',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditUnidadMedidaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Unidad Medida',
        }
      }
    ]
  },
  {
    path: 'unidad-productivas',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: UnidadProductivasComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Unidad Productivas',
        }
      }
    ]
  },
  {
    path: 'add-unidad-productiva',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddUnidadProductivaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Unidad Productiva',
        }
      }
    ]
  },
  {
    path: 'edit-unidad-productiva',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditUnidadProductivaComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Unidad Productiva',
        }
      }
    ]
  },
  {
    path: 'usuarios',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: UsuariosComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Usuarios',
        }
      }
    ]
  },
  {
    path: 'add-usuario',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddUsuarioComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Usuario',
        }
      }
    ]
  },
  {
    path: 'edit-usuario',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditUsuarioComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit Usuario',
        }
      }
    ]
  },
  {
    path: 'users',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: UsersComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Users',
        }
      }
    ]
  },
  {
    path: 'roles',
    children: [
      {
        path: '',
        data: {
          roles: ['Everybody'],
        },
        component: RolesComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Roles',
        }
      }
    ]
  },
  {
    path: 'add-role',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddRoleComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add Role',
        }
      }
    ]
  },
  {
    path: 'edit-user',
    children: [
      {
        path: ':Id',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: EditUserComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Edit User',
        }
      }
    ]
  },
  {
    path: 'profile',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: ProfileComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Profile',
        }
      }
    ]
  },
  {
    path: 'unauthorized',
    children: [
      {
        path: '',
        data: {
          roles: ['Everybody'],
        },
        component: UnauthorizedComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Unauthorized',
        }
      }
    ]
  },
  {
    path: 'add-user',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: AddUserComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Add User',
        }
      }
    ]
  },
  {
    path: 'register-user',
    children: [
      {
        path: '',
        data: {
          roles: ['Everybody'],
        },
        component: RegisterUserComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Register User',
        }
      }
    ]
  },
  {
    path: 'filter',
    children: [
      {
        path: '',
        canActivate: [AuthGuard],
        data: {
          roles: ['Authenticated'],
        },
        component: FilterComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Filter',
        }
      }
    ]
  },
  { path: '', redirectTo: '/calidads', pathMatch: 'full' }
];

export const popupRoutes: Routes = [
];

export const routes: Routes = [
 {
    path: 'login',
    children: [
      {
        path: '',
        component: LoginComponent
      },
      {
        path: '',
        component: PageTitleComponent,
        outlet: 'title',
        data: {
          title: 'Login'
        }
      }
    ]
  },
  ...pageRoutes
];

export const AppRoutes: ModuleWithProviders = RouterModule.forRoot(routes);
