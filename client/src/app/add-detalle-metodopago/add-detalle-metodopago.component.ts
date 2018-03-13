import { Component, Injector } from '@angular/core';
import { AddDetalleMetodopagoGenerated } from './add-detalle-metodopago-generated.component';

@Component({
  selector: 'add-detalle-metodopago',
  templateUrl: './add-detalle-metodopago.component.html'
})
export class AddDetalleMetodopagoComponent extends AddDetalleMetodopagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
