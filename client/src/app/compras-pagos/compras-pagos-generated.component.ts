/*
  This file is automatically generated. Any changes will be overwritten.
  Modify compras-pagos.component.ts instead.
*/
import { ChangeDetectorRef, ViewChild, AfterViewInit, Injector, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';

import { NotificationService, DialogService, DIALOG_PARAMETERS, DialogRef } from '@radzen/angular';
import { GridComponent } from '@radzen/angular';
import { AddComprasPagoComponent } from '../add-compras-pago/add-compras-pago.component';
import { EditComprasPagoComponent } from '../edit-compras-pago/edit-compras-pago.component';

import { AgriculturebdService } from '../agriculturebd.service';
import { SecurityService } from '../security.service';

export class ComprasPagosGenerated implements AfterViewInit, OnInit, OnDestroy {
  // Components
  @ViewChild(GridComponent) grid0: GridComponent;

  router: Router;

  cd: ChangeDetectorRef;

  route: ActivatedRoute;

  notificationService: NotificationService;

  dialogService: DialogService;

  dialogRef: DialogRef;

  _location: Location;

  _subscription: Subscription;

  agriculturebd: AgriculturebdService;

  security: SecurityService;

  getComprasPagosResult: any;

  getComprasPagosCount: any;

  parameters: any;

  constructor(private injector: Injector) {
  }

  ngOnInit() {
    this.notificationService = this.injector.get(NotificationService);

    this.dialogService = this.injector.get(DialogService);

    this.dialogRef = this.injector.get(DialogRef, null);

    this.router = this.injector.get(Router);

    this.cd = this.injector.get(ChangeDetectorRef);

    this._location = this.injector.get(Location);

    this.route = this.injector.get(ActivatedRoute);

    this.agriculturebd = this.injector.get(AgriculturebdService);
    this.security = this.injector.get(SecurityService);
  }

  ngAfterViewInit() {
    this._subscription = this.route.params.subscribe(parameters => {
      if (this.dialogRef) {
        this.parameters = this.injector.get(DIALOG_PARAMETERS);
      } else {
        this.parameters = parameters;
      }
      this.load();
      this.cd.detectChanges();
    });
  }

  ngOnDestroy() {
    this._subscription.unsubscribe();
  }


  load() {
    this.agriculturebd.getComprasPagos(null, this.grid0.allowPaging ? this.grid0.pageSize : null, this.grid0.allowPaging ? 0 : null, null, this.grid0.allowPaging, `Compra,Pago`)
    .subscribe((result: any) => {
      this.getComprasPagosResult = result.value;

      this.getComprasPagosCount = this.grid0.allowPaging ? result['@odata.count'] : result.value.length;
    }, (result: any) => {

    });
  }

  grid0LoadData(event: any) {
    this.agriculturebd.getComprasPagos(`${event.filter}`, this.grid0.allowPaging ? event.top : null, this.grid0.allowPaging ? event.skip : null, `${event.orderby}`, this.grid0.allowPaging, `Compra,Pago`)
    .subscribe((result: any) => {
      this.getComprasPagosResult = result.value;

      this.getComprasPagosCount = this.grid0.allowPaging ? result['@odata.count'] : result.value.length;
    }, (result: any) => {

    });
  }

  grid0Delete(event: any) {
    this.agriculturebd.deleteComprasPago(event.Id)
    .subscribe((result: any) => {
      this.notificationService.notify({ severity: "success", summary: `Success`, detail: `ComprasPago deleted!` });
    }, (result: any) => {
      this.notificationService.notify({ severity: "error", summary: `Error`, detail: `Unable to delete ComprasPago` });
    });
  }

  grid0Add(event: any) {
    this.dialogService.open(AddComprasPagoComponent, { parameters: {}, title: 'Add Compras Pago' });
  }

  grid0RowSelect(event: any) {
    this.dialogService.open(EditComprasPagoComponent, { parameters: {Id: event.Id}, title: 'Edit Compras Pago' });
  }
}