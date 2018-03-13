import { Component, Injector } from '@angular/core';
import { AddDetalleOfertumGenerated } from './add-detalle-ofertum-generated.component';

@Component({
  selector: 'add-detalle-ofertum',
  templateUrl: './add-detalle-ofertum.component.html'
})
export class AddDetalleOfertumComponent extends AddDetalleOfertumGenerated {
  constructor(injector: Injector) {
    super(injector);
  }
}
