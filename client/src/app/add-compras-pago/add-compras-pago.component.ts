import { Component, Injector } from '@angular/core';
import { AddComprasPagoGenerated } from './add-compras-pago-generated.component';

@Component({
  selector: 'add-compras-pago',
  templateUrl: './add-compras-pago.component.html'
})
export class AddComprasPagoComponent extends AddComprasPagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
