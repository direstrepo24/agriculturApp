import { Component, Injector } from '@angular/core';
import { AddPagoGenerated } from './add-pago-generated.component';

@Component({
  selector: 'add-pago',
  templateUrl: './add-pago.component.html'
})
export class AddPagoComponent extends AddPagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
