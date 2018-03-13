import { Component, Injector } from '@angular/core';
import { EditDetalleMetodopagoGenerated } from './edit-detalle-metodopago-generated.component';

@Component({
  selector: 'edit-detalle-metodopago',
  templateUrl: './edit-detalle-metodopago.component.html'
})
export class EditDetalleMetodopagoComponent extends EditDetalleMetodopagoGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
