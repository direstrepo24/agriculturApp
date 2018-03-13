/*
  This file is automatically generated. Any changes will be overwritten.
  Modify roles.component.ts instead.
*/
import { ChangeDetectorRef, ViewChild, AfterViewInit, Injector, OnInit, OnDestroy } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Subscription } from 'rxjs';

import { NotificationService, DialogService, DIALOG_PARAMETERS, DialogRef } from '@radzen/angular';
import { GridComponent } from '@radzen/angular';
import { AddRoleComponent } from '../add-role/add-role.component';

import { SecurityService } from '../security.service';

export class RolesGenerated implements AfterViewInit, OnInit, OnDestroy {
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

  security: SecurityService;

  getRolesResult: any;

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
    this.security.getRoles(null, null, null, null, null, null)
    .subscribe((result: any) => {
      this.getRolesResult = result.value;
    }, (result: any) => {

    });
  }

  grid0Delete(event: any) {
    this.security.deleteRole(`${event.Id}`)
    .subscribe((result: any) => {
      this.notificationService.notify({ severity: "info", summary: `Success`, detail: `Role "${event.Name}" has been deleted.` });
    }, (result: any) => {
      this.notificationService.notify({ severity: "error", summary: `Cannot delete role`, detail: `${result.error.message}` });
    });
  }

  grid0Add(event: any) {
    this.dialogService.open(AddRoleComponent, { parameters: {}, title: 'Add Role' });
  }
}
