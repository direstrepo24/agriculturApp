import { Component, Injector } from '@angular/core';
import { EditDetalleOfertumGenerated } from './edit-detalle-ofertum-generated.component';

@Component({
  selector: 'edit-detalle-ofertum',
  templateUrl: './edit-detalle-ofertum.component.html'
})
export class EditDetalleOfertumComponent extends EditDetalleOfertumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
