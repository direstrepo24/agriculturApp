import { HostListener, Component, Input } from '@angular/core';
import { NavigationEnd, Router, ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { SecurityService } from './security.service';

@Component({
  selector: 'page-title',
  template: '{{ (route.data | async).title }}'
})
export class PageTitleComponent {
  constructor(public route: ActivatedRoute) {
  }
}

@Component({
  selector: 'navigation-menu',
  template: `
  <ul class="ultima-menu ultima-main-menu clearfix">
      <li routerLinkActive="active-menuitem" *ngFor="let page of pages">
        <a [routerLink]="page.link">{{ page.name }}</a>
      </li>
  </ul>`
})
export class NavigationMenuComponent {
  @Input() pages = []
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  menuActive = true;
  mobileMenuActive = false;
  pages = [
      {
        name: 'Calidads',
        link: '/calidads',
        access: ['Authenticated']
      },
      {
        name: 'Categoria Insumos',
        link: '/categoria-insumos',
        access: ['Authenticated']
      },
      {
        name: 'Categoria',
        link: '/categoria',
        access: ['Authenticated']
      },
      {
        name: 'Ciudads',
        link: '/ciudads',
        access: ['Authenticated']
      },
      {
        name: 'Compras',
        link: '/compras',
        access: ['Authenticated']
      },
      {
        name: 'Compras Pagos',
        link: '/compras-pagos',
        access: ['Authenticated']
      },
      {
        name: 'Control Plagas',
        link: '/control-plagas',
        access: ['Authenticated']
      },
      {
        name: 'Cultivos',
        link: '/cultivos',
        access: ['Authenticated']
      },
      {
        name: 'Departamentos',
        link: '/departamentos',
        access: ['Authenticated']
      },
      {
        name: 'Detalle Categoria Insumos',
        link: '/detalle-categoria-insumos',
        access: ['Authenticated']
      },
      {
        name: 'Detalle Compras',
        link: '/detalle-compras',
        access: ['Authenticated']
      },
      {
        name: 'Detalle Metodopagos',
        link: '/detalle-metodopagos',
        access: ['Authenticated']
      },
      {
        name: 'Detalle Oferta',
        link: '/detalle-oferta',
        access: ['Authenticated']
      },
      {
        name: 'Detalle Tipo Productos',
        link: '/detalle-tipo-productos',
        access: ['Authenticated']
      },
      {
        name: 'Enfermedades',
        link: '/enfermedades',
        access: ['Authenticated']
      },
      {
        name: 'Equipos',
        link: '/equipos',
        access: ['Authenticated']
      },
      {
        name: 'Fotos',
        link: '/fotos',
        access: ['Authenticated']
      },
      {
        name: 'Insumos',
        link: '/insumos',
        access: ['Authenticated']
      },
      {
        name: 'Laboratorios',
        link: '/laboratorios',
        access: ['Authenticated']
      },
      {
        name: 'Localizacion Ups',
        link: '/localizacion-ups',
        access: ['Authenticated']
      },
      {
        name: 'Lotes',
        link: '/lotes',
        access: ['Authenticated']
      },
      {
        name: 'Metodo Pagos',
        link: '/metodo-pagos',
        access: ['Authenticated']
      },
      {
        name: 'Notificaciones',
        link: '/notificaciones',
        access: ['Authenticated']
      },
      {
        name: 'Oferta',
        link: '/oferta',
        access: ['Authenticated']
      },
      {
        name: 'Pagos',
        link: '/pagos',
        access: ['Authenticated']
      },
      {
        name: 'Produccions',
        link: '/produccions',
        access: ['Authenticated']
      },
      {
        name: 'Product Categoria',
        link: '/product-categoria',
        access: ['Authenticated']
      },
      {
        name: 'Productos',
        link: '/productos',
        access: ['Authenticated']
      },
      {
        name: 'Receta',
        link: '/receta',
        access: ['Authenticated']
      },
      {
        name: 'Rols',
        link: '/rols',
        access: ['Authenticated']
      },
      {
        name: 'Tipo Insumos',
        link: '/tipo-insumos',
        access: ['Authenticated']
      },
      {
        name: 'Tipo Productos',
        link: '/tipo-productos',
        access: ['Authenticated']
      },
      {
        name: 'Tratamientos',
        link: '/tratamientos',
        access: ['Authenticated']
      },
      {
        name: 'Type Notifications',
        link: '/type-notifications',
        access: ['Authenticated']
      },
      {
        name: 'Unidad Medidas',
        link: '/unidad-medidas',
        access: ['Authenticated']
      },
      {
        name: 'Unidad Productivas',
        link: '/unidad-productivas',
        access: ['Authenticated']
      },
      {
        name: 'Usuarios',
        link: '/usuarios',
        access: ['Authenticated']
      },
      {
        name: 'Filter',
        link: '/filter',
        access: ['Authenticated']
      },
  ];

  accessiblePages: any[];

  profileActive = false;
  hamburgerMenuActive = false;

  constructor (public security: SecurityService,public router: Router, private route: ActivatedRoute, private location: Location) {
    router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        this.accessiblePages = this.pages.filter(page => this.isPageAccessible(page));
      }
    });

  }

  isPageAccessible(page) {
    return !page.access || this.security.isInRole(page.access);
  }

  onLogout(event) {
    event.preventDefault();

    this.security.logout();
  }

  onHamburgerMenuClick(event) {
    event.preventDefault();

    this.hamburgerMenuActive = !this.hamburgerMenuActive;
  }

  @HostListener('document:click')
  closeProfile() {
    this.profileActive = false;
  }

  onProfileClick(event) {
    event.preventDefault();
    event.stopPropagation();

    this.profileActive = !this.profileActive;
  }

  onToggleMenuClick(event) {
    event.preventDefault();

    if(this.isDesktop()) {
      this.menuActive = !this.menuActive;
    } else {
      this.mobileMenuActive = !this.mobileMenuActive;
    }
  }

  isDesktop() {
    return window.innerWidth > 1024;
  }
}
