/*
  This file is automatically generated. Any changes will be overwritten.
  Modify tipo-insumos.component.ts instead.
*/
import { ChangeDetectorRef, ViewChild, AfterViewInit, Injector, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';

import { NotificationService, DialogService, DIALOG_PARAMETERS, DialogRef } from '@radzen/angular';
import { GridComponent } from '@radzen/angular';
import { AddTipoInsumoComponent } from '../add-tipo-insumo/add-tipo-insumo.component';
import { EditTipoInsumoComponent } from '../edit-tipo-insumo/edit-tipo-insumo.component';

import { AgriculturebdService } from '../agriculturebd.service';
import { SecurityService } from '../security.service';

export class TipoInsumosGenerated implements AfterViewInit, OnInit, OnDestroy {
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

  getTipoInsumosResult: any;

  getTipoInsumosCount: any;

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
    this.agriculturebd.getTipoInsumos(null, this.grid0.allowPaging ? this.grid0.pageSize : null, this.grid0.allowPaging ? 0 : null, null, this.grid0.allowPaging, null)
    .subscribe((result: any) => {
      this.getTipoInsumosResult = result.value;

      this.getTipoInsumosCount = this.grid0.allowPaging ? result['@odata.count'] : result.value.length;
    }, (result: any) => {

    });
  }

  grid0LoadData(event: any) {
    this.agriculturebd.getTipoInsumos(`${event.filter}`, this.grid0.allowPaging ? event.top : null, this.grid0.allowPaging ? event.skip : null, `${event.orderby}`, this.grid0.allowPaging, ``)
    .subscribe((result: any) => {
      this.getTipoInsumosResult = result.value;

      this.getTipoInsumosCount = this.grid0.allowPaging ? result['@odata.count'] : result.value.length;
    }, (result: any) => {

    });
  }

  grid0Delete(event: any) {
    this.agriculturebd.deleteTipoInsumo(event.Id)
    .subscribe((result: any) => {
      this.notificationService.notify({ severity: "success", summary: `Success`, detail: `TipoInsumo deleted!` });
    }, (result: any) => {
      this.notificationService.notify({ severity: "error", summary: `Error`, detail: `Unable to delete TipoInsumo` });
    });
  }

  grid0Add(event: any) {
    this.dialogService.open(AddTipoInsumoComponent, { parameters: {}, title: 'Add Tipo Insumo' });
  }

  grid0RowSelect(event: any) {
    this.dialogService.open(EditTipoInsumoComponent, { parameters: {Id: event.Id}, title: 'Edit Tipo Insumo' });
  }
}
