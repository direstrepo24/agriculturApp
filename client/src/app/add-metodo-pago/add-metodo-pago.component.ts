import { Component, Injector } from '@angular/core';
import { AddMetodoPagoGenerated } from './add-metodo-pago-generated.component';

@Component({
  selector: 'add-metodo-pago',
  templateUrl: './add-metodo-pago.component.html'
})
export class AddMetodoPagoComponent extends AddMetodoPagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
