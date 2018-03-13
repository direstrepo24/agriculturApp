/*
  This file is automatically generated. Any changes will be overwritten.
  Modify cultivos.component.ts instead.
*/
import { ChangeDetectorRef, ViewChild, AfterViewInit, Injector, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';

import { NotificationService, DialogService, DIALOG_PARAMETERS, DialogRef } from '@radzen/angular';
import { GridComponent } from '@radzen/angular';
import { AddCultivoComponent } from '../add-cultivo/add-cultivo.component';
import { EditCultivoComponent } from '../edit-cultivo/edit-cultivo.component';

import { AgriculturebdService } from '../agriculturebd.service';
import { SecurityService } from '../security.service';

export class CultivosGenerated implements AfterViewInit, OnInit, OnDestroy {
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

  getCultivosResult: any;

  getCultivosCount: any;

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
    this.agriculturebd.getCultivos(null, this.grid0.allowPaging ? this.grid0.pageSize : null, this.grid0.allowPaging ? 0 : null, null, this.grid0.allowPaging, `DetalleTipoProducto,Lote`)
    .subscribe((result: any) => {
      this.getCultivosResult = result.value;

      this.getCultivosCount = this.grid0.allowPaging ? result['@odata.count'] : result.value.length;
    }, (result: any) => {

    });
  }

  grid0LoadData(event: any) {
    this.agriculturebd.getCultivos(`${event.filter}`, this.grid0.allowPaging ? event.top : null, this.grid0.allowPaging ? event.skip : null, `${event.orderby}`, this.grid0.allowPaging, `DetalleTipoProducto,Lote`)
    .subscribe((result: any) => {
      this.getCultivosResult = result.value;

      this.getCultivosCount = this.grid0.allowPaging ? result['@odata.count'] : result.value.length;
    }, (result: any) => {

    });
  }

  grid0Delete(event: any) {
    this.agriculturebd.deleteCultivo(event.Id)
    .subscribe((result: any) => {
      this.notificationService.notify({ severity: "success", summary: `Success`, detail: `Cultivo deleted!` });
    }, (result: any) => {
      this.notificationService.notify({ severity: "error", summary: `Error`, detail: `Unable to delete Cultivo` });
    });
  }

  grid0Add(event: any) {
    this.dialogService.open(AddCultivoComponent, { parameters: {}, title: 'Add Cultivo' });
  }

  grid0RowSelect(event: any) {
    this.dialogService.open(EditCultivoComponent, { parameters: {Id: event.Id}, title: 'Edit Cultivo' });
  }
}
