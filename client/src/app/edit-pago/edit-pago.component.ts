import { Component, Injector } from '@angular/core';
import { EditPagoGenerated } from './edit-pago-generated.component';

@Component({
  selector: 'edit-pago',
  templateUrl: './edit-pago.component.html'
})
export class EditPagoComponent extends EditPagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
