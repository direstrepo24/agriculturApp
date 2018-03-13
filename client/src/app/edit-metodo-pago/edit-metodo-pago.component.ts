import { Component, Injector } from '@angular/core';
import { EditMetodoPagoGenerated } from './edit-metodo-pago-generated.component';

@Component({
  selector: 'edit-metodo-pago',
  templateUrl: './edit-metodo-pago.component.html'
})
export class EditMetodoPagoComponent extends EditMetodoPagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
