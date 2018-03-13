import { Component, Injector } from '@angular/core';
import { EditComprasPagoGenerated } from './edit-compras-pago-generated.component';

@Component({
  selector: 'edit-compras-pago',
  templateUrl: './edit-compras-pago.component.html'
})
export class EditComprasPagoComponent extends EditComprasPagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
