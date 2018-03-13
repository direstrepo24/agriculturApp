/*
  This file is automatically generated. Any changes will be overwritten.
  Modify edit-recetum.component.ts instead.
*/
import { ChangeDetectorRef, ViewChild, AfterViewInit, Injector, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';

import { NotificationService, DialogService, DIALOG_PARAMETERS, DialogRef } from '@radzen/angular';
import { FormComponent } from '@radzen/angular';

import { AgriculturebdService } from '../agriculturebd.service';
import { SecurityService } from '../security.service';

export class EditRecetumGenerated implements AfterViewInit, OnInit, OnDestroy {
  // Components
  @ViewChild(FormComponent) form0: FormComponent;

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

  recetum: any;

  getEquiposResult: any;

  getInsumosResult: any;

  getUnidadMedidasResult: any;

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
    this.agriculturebd.getRecetumById(this.parameters.Id)
    .subscribe((result: any) => {
      this.recetum = result;
    }, (result: any) => {

    });

    this.agriculturebd.getEquipos(null, null, null, null, null, null)
    .subscribe((result: any) => {
      this.getEquiposResult = result.value;
    }, (result: any) => {

    });

    this.agriculturebd.getInsumos(null, null, null, null, null, null)
    .subscribe((result: any) => {
      this.getInsumosResult = result.value;
    }, (result: any) => {

    });

    this.agriculturebd.getUnidadMedidas(null, null, null, null, null, null)
    .subscribe((result: any) => {
      this.getUnidadMedidasResult = result.value;
    }, (result: any) => {

    });
  }

  form0Cancel(event: any) {
    if (this.dialogRef) {
      this.dialogRef.close();
    } else {
      this._location.back();
    }
  }

  form0Submit(event: any) {
    this.agriculturebd.updateRecetum(this.parameters.Id, event)
    .subscribe((result: any) => {
      if (this.dialogRef) {
        this.dialogRef.close();
      }
      this.router.navigate(['receta']);
    }, (result: any) => {
      this.notificationService.notify({ severity: "error", summary: `Error`, detail: `Unable to update Recetum` });
    });
  }
}
